using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFactory : MonoBehaviour, IFactory
{
    [SerializeField] public GameObject powerUpPrefabs;
    [SerializeField] public Material[] materials;

    public GameObject FactoryMethod(int tag)
    {
        GameObject newPowerUp = Instantiate(powerUpPrefabs);
        newPowerUp.GetComponent<MeshRenderer>().material = materials[tag];
        newPowerUp.GetComponent<Light>().color = materials[tag].color;
        return newPowerUp;
    }
}
