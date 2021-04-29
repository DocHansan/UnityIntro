using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    [Range(0, 1)]
    public float DayTime;

    public float TimeOfCycle;

    public GameObject[] LightObjects;
    public Light[] Lights;

    public GameObject MySun;

    // Start is called before the first frame update
    void Start()
    {
        if (DayTime >= 0.375 && DayTime <= 0.875)
        {
            foreach (GameObject i in LightObjects)
            {
                Lights = i.GetComponentsInChildren<Light>(true);
                foreach (Light j in Lights)
                {
                    if (j != null)
                    {
                        j.enabled = false;
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        DayTime += Time.deltaTime / TimeOfCycle;
        if (DayTime >= 1) DayTime -= 1;
        if (DayTime >= 0.875f)
        {
            foreach (GameObject i in LightObjects)
            {
                Lights = i.GetComponentsInChildren<Light>(true);
                foreach (Light j in Lights)
                {
                    if (j != null)
                    {
                        j.enabled = true;
                    }
                }
            }

        }
        else
        {
            foreach (GameObject i in LightObjects)
            {
                Lights = i.GetComponentsInChildren<Light>(true);
                foreach (Light j in Lights)
                {
                    if (j != null)
                    {
                        j.enabled = false;
                    }
                }
            }
        }

        MySun.transform.localRotation = Quaternion.Euler(DayTime * 360f, 0, 0);
    }
}
