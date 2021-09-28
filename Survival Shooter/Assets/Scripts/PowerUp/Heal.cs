using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Heal : PowerUp
{
    PlayerHealth playerHealth;

    public Heal(PlayerHealth _playerHealth, float _modifier, float _duration = 0f)
    {
        duration = _duration;
        modifier = _modifier;
        playerHealth = _playerHealth;
    }

    public override void DeExecute()
    {

    }

    public override void Execute()
    {
        Debug.Log("heal");
        playerHealth.HealHealth((int)modifier);
    }
}
