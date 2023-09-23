using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private IEnumerator coroutine;

    private void Awake()
    {
        coroutine = KillYourself(2000f * Time.deltaTime);
    }

    private void KillYourself()
    {
        Destroy(gameObject);
    }

    public void StartKillingYourself()
    {
        StartCoroutine(coroutine);
    }

    private IEnumerator KillYourself(float time)
    {
        yield return new WaitForSeconds(time);
        KillYourself();
    }
}
