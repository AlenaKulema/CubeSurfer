using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button[] NumberLevel;
    public Sprite StarButton, noStar;
    public Save Save;
    private void Start()
    {
        for (int i = 0; i < NumberLevel.Length; i++)
        {
            if (PlayerPrefs.HasKey("stars" + i))
            {
                if (PlayerPrefs.GetInt("stars" + i) == 1)
                {
                    NumberLevel[i].transform.GetChild(0).GetComponent<Image>().sprite = StarButton;
                    NumberLevel[i].transform.GetChild(1).GetComponent<Image>().sprite = noStar;
                    NumberLevel[i].transform.GetChild(2).GetComponent<Image>().sprite = noStar;

                }
                else if (PlayerPrefs.GetInt("stars" + i) == 2)
                {
                    NumberLevel[i].transform.GetChild(0).GetComponent<Image>().sprite = StarButton;
                    NumberLevel[i].transform.GetChild(1).GetComponent<Image>().sprite = StarButton;
                    NumberLevel[i].transform.GetChild(2).GetComponent<Image>().sprite = noStar;
                }
                else
                {
                    NumberLevel[i].transform.GetChild(0).GetComponent<Image>().sprite = StarButton;
                    NumberLevel[i].transform.GetChild(1).GetComponent<Image>().sprite = StarButton;
                    NumberLevel[i].transform.GetChild(2).GetComponent<Image>().sprite = StarButton;
                }
            }
            else
            {
                NumberLevel[i].transform.GetChild(0).GetComponent<Image>().sprite = noStar;
                NumberLevel[i].transform.GetChild(1).GetComponent<Image>().sprite = noStar;
                NumberLevel[i].transform.GetChild(2).GetComponent<Image>().sprite = noStar;
            }

        }
        for (int i = 0; i < NumberLevel.Length; i++)
        {
            
            if (!PlayerPrefs.HasKey("NumberLevel" + i))
            {
                if (i <= Save.GetLevelIndex())
                {
                    NumberLevel[i].interactable = true;
                    PlayerPrefs.SetInt("NumberLevel" + i, i);
                }
            }
            else NumberLevel[i].interactable = true;



        }
                
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Scenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);

    }
    public void LoadNumberLevel(int numberLevel)
    {
        Save.SaveLevelIndex(numberLevel);
        SceneManager.LoadScene(1);


    }

}
