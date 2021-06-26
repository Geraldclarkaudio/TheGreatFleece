using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    public Animator anim;

    [SerializeField]
    private GameObject gameOverSequence;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            MeshRenderer render = GetComponent<MeshRenderer>();
            Color color = new Color(0.6f, 0.11f, 0.11f, 0.30f);
            render.material.SetColor("_TintColor", color);
            anim.enabled = false;
            StartCoroutine(SecurityCameraWait());
        }
    }

    IEnumerator SecurityCameraWait()
    {
        yield return new WaitForSeconds(1.5f);
        gameOverSequence.SetActive(true);
    }
}
