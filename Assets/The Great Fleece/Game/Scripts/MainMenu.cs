using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //start goes to game 
    public void StartGame()
    {
        SceneManager.LoadScene("Loading_Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    //quit method == quit game duh

}
