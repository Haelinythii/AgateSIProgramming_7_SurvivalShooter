using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class PowerUp
{
    protected float duration;
    protected float modifier;

    public IEnumerator StartCountDuration() //start eksekusi power up, kemudian tunggu selama durasi dan kemudian lepas powerupnya.
    {
        Execute();
        yield return new WaitForSeconds(duration);
        DeExecute();
    }

    //dapatkan durasi powerupnya
    public float GetDuration()
    {
        return duration;
    }

    public abstract void Execute();
    public abstract void DeExecute();
}
