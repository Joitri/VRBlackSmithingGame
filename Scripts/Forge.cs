using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forge : MonoBehaviour
{
    [SerializeField] float tempControl;

    /// <summary>
    /// OnTriggerStay is called Once per frame for each Collider other that is touching the trigger
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        
        if (other.GetComponent<Temperature>())
        {
            //Debug.Log("Staying inside forge");
            StartCoroutine(UpdateTemperature(other.GetComponent<Temperature>()));
        }
        
    }

    private IEnumerator UpdateTemperature(Temperature temp)
    {

        yield return new WaitForSeconds(temp.GetThermalConduct());
        temp.SetTemperature(tempControl);
    }
}
