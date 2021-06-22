using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverSequence;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameOverSequence.SetActive(true);
        }
    }
}
