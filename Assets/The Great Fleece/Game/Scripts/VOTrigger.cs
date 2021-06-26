using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VOTrigger : MonoBehaviour
{
    [SerializeField]
    private AudioClip voiceOverLine;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            AudioManager.Instance.PlayVOiceOver(voiceOverLine);

            //AudioSource.PlayClipAtPoint(voiceOverLine, Camera.main.transform.position);
           
        }
    }
}
