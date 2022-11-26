using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControl : MonoBehaviour
{
    public float Speed = 3f;
    public LevelManager LevelManager;
    
    void FixedUpdate()
    {
       
        if(LevelManager.CurrenState == LevelManager.State.Playing)
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0, Space.World);
           
        }
        
    }
}
