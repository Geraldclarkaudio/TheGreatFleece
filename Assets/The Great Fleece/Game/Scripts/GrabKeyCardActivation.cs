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
            StartCoroutine(DestroyCollider());

            GameManager.Instance.hasCard = true; 
        }
    }

    IEnumerator DestroyCollider()
    {
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }
}
