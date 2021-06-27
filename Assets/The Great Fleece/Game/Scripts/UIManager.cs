using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("The UIManager is Null!");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
    //create the singletone

    //resart/

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }
    //quit
    public void Quit()
    {
        Application.Quit(); 
    }
}
