using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp
{
    float duration;

    public abstract void Execute();
    public abstract void DeExecute();
}
