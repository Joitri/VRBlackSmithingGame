using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    [SerializeField] private float temperature;
    [SerializeField] private float maliableTemp;
    [SerializeField] private float maxTemp;
    [SerializeField] private bool isOre;
    [SerializeField] private bool isIngot;
    // Seconds for the temp to be increased
    [SerializeField] private float thermalConduct;
    private int numberOfStrikes;
    private bool isMaliable;

    private void Awake()
    {
        numberOfStrikes = Random.Range(2, 5);
    }

    // Update is called once per frame
    void Update()
    {
        CheckTemp();
    }
    
    public float GetTemperature()
    {
        return temperature;
    }

    public float GetThermalConduct()
    {
        return thermalConduct;
    }

    public float GetMaliableTemp()
    {
        return maliableTemp;
    }

    public void SetTemperature(float temp)
    {
        temperature += temp;
    }

    private void CheckTemp()
    {
        if (temperature >= maliableTemp)
        {
            if (isOre)
            {
                GameObject newIngot = Instantiate(GetComponent<OreMorpher>().GetIngot(), transform.position, transform.rotation);
                Destroy(this.GetComponentInParent<SelfDestruct>().gameObject);
            }

            if (temperature >= maxTemp)
            {
                Destroy(this.GetComponentInParent<SelfDestruct>().gameObject);
            }

            isMaliable = true;
        }
    }

    public int GetNumberOfStrikes()
    {
        return numberOfStrikes;
    }
    public void SetNumberOfStrikes()
    {
        temperature = 0;
        numberOfStrikes -= 1;
    }

    public bool GetIsMaliable()
    {
        return isMaliable;
    }

    public bool GetIsOre()
    {
        return isOre;
    }

    public bool GetIsIngot()
    {
        return isIngot;
    }
}
