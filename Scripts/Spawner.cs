using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject itemToSpawn;
    private GameObject newGameObject;

    private void Awake()
    {
        newGameObject = Instantiate(itemToSpawn, transform.position, transform.rotation);
        newGameObject.transform.SetParent(this.gameObject.transform, true);
    }
    private void Update()
    {
        if (!GetComponentInChildren<Temperature>())
        {
            SpawnNewItem();
        }
    }

    private void SpawnNewItem()
    {
        newGameObject = Instantiate(itemToSpawn, transform.position, transform.rotation);
        newGameObject.transform.SetParent(this.gameObject.transform, true);
    }
}
