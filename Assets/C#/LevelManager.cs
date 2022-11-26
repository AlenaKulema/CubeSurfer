using Assets.C_.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    [SerializeField] private LevelList _levelList;
    public Save Save;
    public UIManager UIManager;
    public Player Player;
    
    public int _currentLevelIndex;
    public TMPro.TMP_Text LevelNumber;




    private void Awake()
    {
       
        _currentLevelIndex = Save.GetLevelIndex();
        _currentLevelIndex %= _levelList.Levels.Length;

        GameObject Level = Instantiate(_levelList.Levels[_currentLevelIndex]);
        Level.transform.parent = transform;
       
    }
   

    public enum State
    {
       
        Playing,
        Won,
        Loss,
    }

    public State CurrenState { get; private set; }

    public void OnPlayerFinish()
    {
        LevelNumber.text = "спнбмэ "+(_currentLevelIndex+1)+ " опнидем!".ToString();
        if (CurrenState != State.Playing) return;
        CurrenState = State.Won;

        if (!PlayerPrefs.HasKey("stars" + _currentLevelIndex))
            PlayerPrefs.SetInt("stars" + _currentLevelIndex, Player.Stars);
        else if (Player.Stars> PlayerPrefs.GetInt("stars" + _currentLevelIndex))
            PlayerPrefs.SetInt("stars" + _currentLevelIndex, Player.Stars);

        if (_currentLevelIndex == 4)
            _currentLevelIndex = 2;
        else _currentLevelIndex++;
        Save.SaveLevelIndex(_currentLevelIndex);
        UIManager.Win();


    }

    public void OnPlayerDied()
    {
        if (CurrenState != State.Playing) return;
        CurrenState = State.Loss;
        UIManager.Lose();

    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Restart()
    {
        
        _currentLevelIndex--;
        Save.SaveLevelIndex(_currentLevelIndex);
    }
  

}
