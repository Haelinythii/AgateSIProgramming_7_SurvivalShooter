using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpDetector : MonoBehaviour
{
    private PowerUp powerUp;
    private System.Action OnCollected;
    private void OnTriggerEnter(Collider other)
    {
        //deteksi jika yang menyentuh adalah player
        if(other.tag == "Player" && !other.isTrigger)
        {
            //eksekusi powerup yang diambil serta destroy gameobject
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }

    public void SetPowerUp(System.Action OnCollected)
    {
        this.OnCollected = OnCollected;
    }
}
