using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabKeyCardActivation : MonoBehaviour
{
    [SerializeField]
    private GameObject keyCardCutscene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            keyCardCutscene.SetActive(true);

            Destroy(this.gameObject, 6f);

            GameManager.Instance.hasCard = true; 
        }
    }
}
