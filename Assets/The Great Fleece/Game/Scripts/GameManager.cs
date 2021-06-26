using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("The Game Manager is null");
            }

            return _instance;
        }
    }

    public bool hasCard
    {
        get; set;
    }

    public PlayableDirector introCut;

    private void Awake()
    {
        _instance = this;
    }

    public void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.S))
        {
            introCut.time = 55.0f;
            AudioManager.Instance.PlayMusic();
        }
    }
}
