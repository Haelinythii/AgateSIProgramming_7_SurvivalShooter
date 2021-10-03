using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;

    [SerializeField] MonoBehaviour factory;
    IFactory Factory { get { return factory as IFactory; } }

    [Header("References")]
    public PlayerMovement playerMovement;
    public PlayerHealth playerHealth;

    List<PowerUp> powerUps = new List<PowerUp>();

    bool isSpawned = false;
    [SerializeField] private float PowerupSpawnCooldown = 10f;
    float cooldownTimer;

    private void Awake()
    {
        //masukkan semua powerup yang ada
        powerUps.AddRange(new List<PowerUp>() { new SpeedUp(playerMovement, 1.5f, 5f), new Heal(playerHealth, 50) });
    }

    private void Start()
    {
        //set cooldown timer
        cooldownTimer = PowerupSpawnCooldown;
    }

    private void Update()
    {
        if (isSpawned) return;

        //hitung timer
        cooldownTimer -= Time.deltaTime;

        //jika timer mencapai 0, spawn power up dan reset timer
        if (cooldownTimer < 0f)
        {
            SpawnPowerUp();
            cooldownTimer = PowerupSpawnCooldown;
            isSpawned = true;
        }
    }

    private void SpawnPowerUp()
    {
        //pilih dan create powerup yang akan di spawn
        int spawnPowerUp = Random.Range(0, powerUps.Count);
        GameObject powerUpGO = Factory.FactoryMethod(spawnPowerUp);
        powerUpGO.transform.position = spawnPoint.position;

        //set powerup ke object yang baru dipasang
        powerUpGO.GetComponent<PowerUpDetector>().SetPowerUp(() => {
            StartCoroutine(powerUps[spawnPowerUp].StartCountDuration());
            isSpawned = false;
        });
    }
}
