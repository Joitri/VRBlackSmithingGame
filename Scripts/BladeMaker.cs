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
            BecomeWeapon(other.gameObject);
        }
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
        GameObject newIngot = Instantiate(edgePrefabs[Random.Range(Mathf.Min(0, edgePrefabs.Count), Mathf.Max(0, edgePrefabs.Count))], transform.position, transform.rotation);
        Destroy(this.gameObject);
    }

    public void BecomeWeapon(GameObject gameObject)
    {
        if (!isAttached)
        {
            if (!gameObject.GetComponent<DaggerHilt>().GetIsAttached())
            {
                this.GetComponent<MeshRenderer>().gameObject.transform.SetParent(gameObject.GetComponentInChildren<MeshContainer>().transform, false);
                gameObject.GetComponent<DaggerHilt>().SetIsAttached(true);
                isAttached = true;

            }
        }
    }
}
