using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Control Control;
    public LevelManager LevelManager;
    [SerializeField] private Camera Camera;
    [SerializeField] private Animator Animator;
    [SerializeField] private UIManager UIManager;
    public int Stars=0;



    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent(out CubeBad cubeBad)) return;
        if (cubeBad.Cube == true)
        {
            Animator.SetBool("Fall", true);
            LevelManager.OnPlayerDied();
            Camera.transform.position = new Vector3(transform.position.x-1, transform.position.y+4, transform.position.z-1f);
            Camera.transform.eulerAngles = new Vector3(60, 41, 0);



        }


    }



    public void Update()
    {
        
        Vector3 posishoinPlayer = (Control.Cube[Control.Cube.Count - 1].transform.position);
        posishoinPlayer.y +=0.7f;
        transform.position = posishoinPlayer;
        UIManager.OnStars(Stars);

        

    }

    public void Finish()
    {
        Camera.transform.position = new Vector3(transform.position.x-3, transform.position.y + 1f, transform.position.z - 2);
        Camera.transform.eulerAngles = new Vector3(2, 50, 0);
        Animator.SetBool("Finish", true);
       
        LevelManager.OnPlayerFinish();
      
      
    }

    
}
