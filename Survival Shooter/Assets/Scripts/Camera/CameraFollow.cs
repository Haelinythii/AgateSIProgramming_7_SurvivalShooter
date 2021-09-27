using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Camera Attributes")]
    public float smoothing = 5f;
    Vector3 offset;

    [Header("References")]
    public Transform target;

    private void Start()
    {
        //hitung offset dari camera ke target
        offset = transform.position - target.position;
    }

    private void FixedUpdate()
    {
        //hitung posisi baru camera dengan offset
        Vector3 newCameraPosition = target.position + offset;

        //pindahkan camera ke posisi baru dengan smoothing
        transform.position = Vector3.Lerp(transform.position, newCameraPosition, smoothing * Time.deltaTime);
    }
}
