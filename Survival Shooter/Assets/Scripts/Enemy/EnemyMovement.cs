using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    [Header("References")]
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    NavMeshAgent agent;

    private void Awake()
    {
        //mencari game object dengan tag player
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //dapatkan reference
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            agent.enabled = false;
        }
    }

}
