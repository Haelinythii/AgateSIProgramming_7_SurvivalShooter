using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField] public GameObject[] enemyPrefabs;

    public GameObject FactoryMethod(int tag)
    {
        GameObject newEnemy = Instantiate(enemyPrefabs[tag]);
        return newEnemy;
    }
}
