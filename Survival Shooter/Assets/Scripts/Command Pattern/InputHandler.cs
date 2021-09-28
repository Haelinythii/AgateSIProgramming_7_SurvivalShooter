using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public PlayerShooting playerShooting;

    //list command yang disimpan
    Queue<Command> commands = new Queue<Command>();

    void FixedUpdate()
    {
        //handle input movement
        Command moveCommand = InputMovementHandling();
        if (moveCommand != null)
        {
            commands.Enqueue(moveCommand);

            moveCommand.Execute();
        }
    }

    void Update()
    {
        //handle input tembak
        Command shootCommand = InputShootHandling();
        if (shootCommand != null)
        {
            shootCommand.Execute();
        }
    }

    Command InputMovementHandling()
    {
        //cek jika movement sesuai dengan key nya
        if (Input.GetKey(KeyCode.D))
        {
            return new MoveCommand(playerMovement, 1, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            return new MoveCommand(playerMovement, -1, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            return new MoveCommand(playerMovement, 0, 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            return new MoveCommand(playerMovement, 0, -1);
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            //Undo movement
            return Undo();
        }
        else
        {
            return new MoveCommand(playerMovement, 0, 0);
        }
    }

    Command Undo()
    {
        //cek kalau queue command tidak kosong
        if (commands.Count > 0)
        {
            Command undoCommand = commands.Dequeue();
            undoCommand.UnExecute();
        }
        return null;
    }

    Command InputShootHandling()
    {
        //cek menembak trigger shoot command
        if (Input.GetButtonDown("Fire1"))
        {
            return new ShootCommand(playerShooting);
        }
        else
        {
            return null;
        }
    }
}
