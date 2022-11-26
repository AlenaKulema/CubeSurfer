using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLevel : MonoBehaviour
{
    private float euler;
    private void OnTriggerEnter(Collider other)
    {
        euler = +90;
    }
    private void Update()
    {
        if (euler == 90)
        {
            Quaternion newRotation = Quaternion.AngleAxis(90, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, .05f);
        }
    }

   
}
