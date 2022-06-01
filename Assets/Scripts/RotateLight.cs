using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour
{
    float rotate;
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * (speed * Time.deltaTime));

    }
}
