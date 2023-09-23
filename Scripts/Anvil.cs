﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anvil : MonoBehaviour
{
    //AudioSource
    [SerializeField] private AudioSource _as;
    [SerializeField] private AudioClip collisionSound;
    [SerializeField] private AudioClip destroySound;

    void Start() { 
    // _as = GetComponent<AudioSource>();
    }

    private GameObject ingotGameObject;

    private bool isOnAnvil = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Hammer>() && isOnAnvil)
        {

            if (ingotGameObject.GetComponent<Temperature>())
            {
                if (ingotGameObject.GetComponent<Temperature>().GetIsMaliable())
                {
                    _as.PlayOneShot(collisionSound);
                    ingotGameObject.GetComponent<Temperature>().SetNumberOfStrikes();
                    if (ingotGameObject.GetComponent<Temperature>().GetNumberOfStrikes() < 0)
                    {
                        _as.PlayOneShot(destroySound);
                        DestroyIngot();
                    }
                }
            }
        }

        if (other.GetComponent<BladeMaker>())
        {
            if (other.GetComponent<BladeMaker>().GetEdgePrefabs() != null)
            {
                isOnAnvil = true;
                other.GetComponent<BladeMaker>().SetOnAnvil(isOnAnvil);
                ingotGameObject = other.gameObject;
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<BladeMaker>())
        {
            isOnAnvil = false;
            other.GetComponent<BladeMaker>().SetOnAnvil(isOnAnvil);
            ingotGameObject = null;
        }
    }

    public void DestroyIngot()
    {
        ingotGameObject.SendMessage("BecomeBlade");
        ingotGameObject = null;
    }
}
