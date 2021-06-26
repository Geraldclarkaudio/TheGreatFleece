using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGameScript : MonoBehaviour
{
    public GameObject winCutScene;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player")
        {
            if(GameManager.Instance.hasCard == true)
            {
                winCutScene.SetActive(true);
            }
            else
            {
                Debug.Log("Get the Key Card!");
            }
        }
    }
}
