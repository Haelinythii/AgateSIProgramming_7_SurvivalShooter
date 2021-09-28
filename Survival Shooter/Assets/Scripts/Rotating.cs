using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0f, 5f, 0f);

    private void Update()
    {
        transform.Rotate(rotationSpeed);
    }
}
