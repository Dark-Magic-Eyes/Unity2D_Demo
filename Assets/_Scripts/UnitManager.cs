using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public GameObject GoldCoin;
    public Transform environment;
    private void Start() {
        InvokeRepeating("SpawnCoin", 1f, 0.1f);
    }
    public void SpawnCoin()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-10, 10), 7, 0);
        Instantiate(GoldCoin, spawnPosition, Quaternion.identity, environment);
    }
}
