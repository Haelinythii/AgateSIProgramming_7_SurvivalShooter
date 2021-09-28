using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    PlayerMovement playerMovement;
    float horizontal, vertical;

    public MoveCommand(PlayerMovement _playerMovement, float _horizontal, float _vertical)
    {
        this.playerMovement = _playerMovement;
        this.horizontal = _horizontal;
        this.vertical = _vertical;
    }

    public override void Execute()
    {
        //pindahkan player
        playerMovement.Move(horizontal, vertical);
        //animasikan player
        playerMovement.Animating(horizontal, vertical);
    }

    public override void UnExecute()
    {
        Debug.Log("Undo " + horizontal + " " + vertical); 
        //invers arah dari movement player
        playerMovement.Move(-horizontal, -vertical);
        //animasikan player
        playerMovement.Animating(horizontal, vertical);
    }
}
