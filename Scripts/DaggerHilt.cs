using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerHilt : MonoBehaviour
{
    private bool isAttached = false;

    public void SetIsAttached(bool b)
    {
        isAttached = b;
    }

    public bool GetIsAttached()
    {
        return isAttached;
    }
}
