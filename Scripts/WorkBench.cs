using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkBench : MonoBehaviour
{
    //private GameObject daggerHilt;

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Colider hit : " + other);
    //    if (other.GetComponent<BladeMaker>())
    //    {
    //        if (!other.GetComponent<Temperature>().GetIsIngot())
    //        {
    //            Debug.Log("BladeMaker Pass : " + other);
    //            if (daggerHilt != null)
    //            {
    //                Debug.Log("Dagger Hilt Not Null : " + other);
    //                Transform transform = other.gameObject.transform;
    //                Debug.Log("Other.GameObject.Transform : " + transform);
    //                other.SendMessage("BecomeWeapon()", false);
    //            }
    //        }
    //    }
    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.GetComponent<DaggerHilt>())
    //    {
    //        if (daggerHilt != null)
    //        {
    //            daggerHilt = other.gameObject;
    //        }
    //        Debug.Log(daggerHilt);
    //    }
    //    else
    //    {
    //        //if (other.GetComponent<Temperature>().GetIsIngot())
    //        //daggerHilt = null;
    //        Debug.Log(daggerHilt);
    //    }
    //}

}
