using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject panelWin;
    public GameObject panelLose;
    public GameObject panelGame;
    

    
    
    
    public GameObject[] Star= new GameObject[3];
   
   


    

    public void Win()
    {
        panelWin.SetActive(true);
        panelGame.SetActive(false);
        
    }


    public void Lose()
    {
        panelLose.SetActive(true);
        panelGame.SetActive(false);

    }

    public void OnStars(int star)
    {
        if (star > 0)
        {
            star -= 1;
            Star[star].SetActive(true);
            

        }
           
    }
    public void Scenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);

    }

   

}
