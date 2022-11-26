using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBad : MonoBehaviour
{
    
    public bool Cube;
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (!other.TryGetComponent(out Control control)) return;
        
        control.enabled = false;
        control.OnAudio();





        if (Cube == true)
        {
            
            control.transform.SetParent(gameObject.transform);
            

        }

            


    }
}
