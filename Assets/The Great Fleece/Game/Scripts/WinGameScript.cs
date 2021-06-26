using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGameScript : MonoBehaviour
{
    public GameObject winCutScene;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (GameManager.Instance.hasCard == true)
            {
                winCutScene.SetActive(true);
                Debug.Log("Why isnt there a cutscene?");

            }
            else
            {
                Debug.Log("Go get the keycard!");

                //play audio?

            }
        }
            
        
    }
}
