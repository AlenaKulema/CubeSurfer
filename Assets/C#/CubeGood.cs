using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGood : MonoBehaviour
{
    public Control Control;
    
   



    private void OnTriggerEnter(Collider other)
    {
       
        Control = GameObject.FindGameObjectWithTag("Cube").GetComponent<Control>();
        
        Control.CubeAdd();
       
        Destroy(gameObject);
       
     
    }

   
}
