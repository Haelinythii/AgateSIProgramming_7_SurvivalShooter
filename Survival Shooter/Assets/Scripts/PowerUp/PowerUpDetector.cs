using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpDetector : MonoBehaviour
{
    private PowerUp powerUp;
    private System.Action OnCollected;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !other.isTrigger)
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }

    public void SetPowerUp(System.Action OnCollected)
    {
        this.OnCollected = OnCollected;
    }
}
