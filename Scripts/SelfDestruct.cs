using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private IEnumerator coroutine;

    private void Awake()
    {
        coroutine = DestroyYourself(2000f * Time.deltaTime);
    }

    private void DestroyYourself()
    {
        Destroy(gameObject);
    }

    public void StartDestroyingYourself()
    {
        StartCoroutine(coroutine);
    }

    private IEnumerator DestroyYourself(float time)
    {
        yield return new WaitForSeconds(time);
        DestroyYourself();
    }
}
