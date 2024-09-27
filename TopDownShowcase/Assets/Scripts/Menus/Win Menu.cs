using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    [SerializeField]
    string levelToLoad = "Main Menu";
    [SerializeField]
    string levelToLoad2 = "Level 1";
    public void QuitToMenu()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    public void GoToLevel()
    {
        SceneManager.LoadScene(levelToLoad2);
    }
}
