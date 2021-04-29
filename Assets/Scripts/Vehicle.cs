using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float turnSpeed;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * y * speed * Time.deltaTime);
        if (y >= 0)
        {
            transform.Rotate(Vector3.up * x * turnSpeed * Time.deltaTime);
        }
        if (y <= 0)
        {
            transform.Rotate(- Vector3.up * x * turnSpeed * Time.deltaTime);
        }
    }
}
