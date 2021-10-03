using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpeedUp : PowerUp
{
    PlayerMovement playerMovement;

    public SpeedUp(PlayerMovement _playerMovement, float _modifier, float _duration = 0f)
    {
        duration = _duration;
        modifier = _modifier;
        playerMovement = _playerMovement;
    }

    public override void DeExecute() //matikan speed up dengan membagi speed yang sudah dikali
    {
        playerMovement.speed /= modifier;
    }

    public override void Execute() //kali speed dengan modifier agar mempercepat speed player
    {
        playerMovement.speed *= modifier;
    }
}
