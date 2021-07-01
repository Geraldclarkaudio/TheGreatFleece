using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    [SerializeField]
    private AudioClip footstepSoft;

    [SerializeField]
    private AudioClip footstepHard;

    public Animator _anim;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
      
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void FootStepSound()
    {
      
        audioSource.clip = footstepSoft;
        audioSource.Play();

        //if hard floor 
        //audioSource.clip = footstepHard;
    }
}
