using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    [SerializeField] float hammerQualityMin;
    [SerializeField] float hammerQualityMax;
    float hammerStats = 0;
    
    //private void Update()
    //{
    //    hammerStats = Random.Range(hammerQualityMin, hammerQualityMax);
    //}

    public void OnTriggerEnter(Collider other)
    {


        //if (other.GetComponent<BladeMaker>())
        //{
        //    //{
        //    //    Debug.Log("onAnvil + Hammer Passed");
        //    //    GameObject newIngot = Instantiate(other.GetComponent<BladeMaker>().GetEdgePrefabs()
        //    //                                 [Random.Range(0, other.GetComponent<BladeMaker>().GetEdgePrefabs().Length)],
        //    //                                 transform.position, transform.rotation);
        //    //    //newIngot.transform.position = transform.position;
        //    //    Destroy(other.gameObject);
        //    if (other.GetComponent<BladeMaker>().GetOnAnvil())
        //    {
        //        Debug.Log(other.GetComponent<BladeMaker>().GetEdgePrefabs());
        //        foreach (GameObject gameObject in other.GetComponent<BladeMaker>().GetEdgePrefabs())
        //        {
        //            Debug.Log(gameObject);
        //        }

        //        GameObject newBlade = Instantiate(other.GetComponent<BladeMaker>().GetEdgePrefabs()
        //                                     [Random.Range(0, other.GetComponent<BladeMaker>().GetEdgePrefabs().Count)],
        //                                     transform.position, transform.rotation) as GameObject;
        //        newBlade.transform.SetParent(null);
        //        //newIngot.transform.position = transform.position;
        //        //newIngot = null;
        //        //Destroy(newIngot);
        //        Destroy(other.gameObject);
        //    }
        //}
        //if (other.GetComponent<Anvil>())
        //{
        //    if (other.GetComponent<Anvil>().GetOnAnvil() && other.GetComponent<Anvil>().GetOptions().Count > 0)
        //    {
        //        Debug.Log(other.GetComponent<Anvil>().GetIngotGameObject().gameObject);
        //        foreach (GameObject gameObject in other.GetComponent<Anvil>().GetOptions())
        //        {
        //            Debug.Log(gameObject);
        //        }

        //        GameObject newBlade = Instantiate(other.GetComponent<Anvil>().GetOptions()
        //                                     [Random.Range(0, other.GetComponent<Anvil>().GetOptions().Count)],
        //                                     transform.position, transform.rotation) as GameObject;
        //        newBlade.transform.SetParent(null);
        //        //newIngot.transform.position = transform.position;
        //        //newIngot = null;
        //        //Destroy(newIngot);
        //        //Destroy(other.GetComponent<Anvil>().GetIngotGameObject().gameObject);
        //        Debug.Log(other.GetComponent<Anvil>().GetIngotGameObject().gameObject);
        //        other.GetComponent<Anvil>().SetFillerObjects();
        //        Debug.Log(other.GetComponent<Anvil>().GetIngotGameObject());
        //    }
        //}
    }

    public void OnTriggerExit(Collider other)
    {
        
    }
}
