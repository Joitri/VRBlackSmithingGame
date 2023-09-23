using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngotGrabber : MonoBehaviour
{
    [SerializeField] private Transform locationToGrip;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.GetComponent<Temperature>())
    //    {
    //        GameObject ingot = other.GetComponent<GameObject>();

    //        while (ingot.GetComponent<Temperature>().GetTemperature() >= ingot.GetComponent<Temperature>().GetMaliableTemp())
    //        {
    //            ingot.transform.position = this.transform.position;
    //        }
    //    }
    //}
}
