using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeMaker : MonoBehaviour
{
    [SerializeField] private List<GameObject> edgePrefabs;

    [SerializeField] private float edgeQualityMod;

    private bool onAnvil;
    private bool isAttached = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DaggerHilt>())
        {
            Debug.Log("I touched : " + other);
            BecomeWeapon(other.gameObject);
        }
    }

    private void Update()
    {
        //Debug.Log(onAnvil);
    }
    public void SetOnAnvil(bool b)
    {
        onAnvil = b;
    }

    public bool GetOnAnvil()
    {
        return onAnvil;
    }

    public List<GameObject> GetEdgePrefabs()
    {
        return edgePrefabs;
    }

    public void BecomeBlade()
    {
        Debug.Log("onAnvil + Hammer Passed");
        GameObject newIngot = Instantiate(edgePrefabs[Random.Range(Mathf.Min(0, edgePrefabs.Count), Mathf.Max(0, edgePrefabs.Count))], transform.position, transform.rotation);
        //newIngot.transform.position = transform.position;
        Destroy(this.gameObject);
    }

    public void BecomeWeapon(GameObject gameObject)
    {
        if (!isAttached)
        {
            Debug.Log("Trying to become a child to : " + gameObject.transform.parent);
            if (!gameObject.GetComponent<DaggerHilt>().GetIsAttached())
            {
                this.GetComponent<MeshRenderer>().gameObject.transform.SetParent(gameObject.GetComponentInChildren<MeshContainer>().transform, false);
                //this.GetComponent<MeshRenderer>().gameObject.transform.position = gameObject.transform.position;
                gameObject.GetComponent<DaggerHilt>().SetIsAttached(true);
                isAttached = true;
                Debug.Log("I Tried to become a child and : Succeeded");

            }
        }
    }
}
