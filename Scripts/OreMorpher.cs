using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreMorpher : MonoBehaviour
{
    [SerializeField] private GameObject ingotToBecome;

    public GameObject GetIngot()
    {
        return ingotToBecome;
    }
}
