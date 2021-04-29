using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratingObjects : MonoBehaviour
{
    public GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 32; i++) 
        {
            for (int j = 0; j < 32; j++)
            {
                Instantiate(Sphere, new Vector3(i, 0f, j), Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
