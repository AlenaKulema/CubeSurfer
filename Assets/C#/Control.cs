using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Control : MonoBehaviour
{
    
    public float Senstivity;
    

    public List<GameObject> Cube = new List<GameObject>();
    
    public GameObject cubePrefab;
    public Audio Audio;

    



    private Vector3 _previousMousePosition;



   
   

    private void Start()
    {
        
        Cube.Add(gameObject);
        Audio = GameObject.FindGameObjectWithTag("Sound").GetComponent<Audio>();


    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 posish = transform.position;
        posish.x = -6;
        transform.position = posish;


        for (int i = 0; i < Cube.Count; i++)
        {
           
            if (Input.GetMouseButton(0))
            {
                Vector3 delta = Input.mousePosition;
                Vector3 posishoinPlayer = Cube[i].transform.position;
                posishoinPlayer.z = delta.x * Senstivity;
                posishoinPlayer.z -= 2;
                posishoinPlayer.z = Mathf.Clamp(posishoinPlayer.z, -1.5f, 1.5f);

                Cube[i].transform.position = posishoinPlayer;
            }
            _previousMousePosition = Input.mousePosition;
            
        }


        

    }

   
    public void CubeAdd()
    {
       
        Vector3 newLastPosition = Cube[Cube.Count - 1].transform.position;
        newLastPosition.y += 1;
        Cube.Add(GameObject.Instantiate(cubePrefab, newLastPosition, Quaternion.identity) as GameObject);
        Audio.BubbleAudio();



    }

    public void OnAudio()
    {
        Audio.PunchAudio();
    }
}