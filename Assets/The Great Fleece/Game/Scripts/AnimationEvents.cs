using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    [SerializeField]
    private AudioClip footstepSoft;

    [SerializeField]
    private AudioClip footstepHard;

    AudioSource audioSource;
    public MeshRenderer floorMesh;


    // Start is called before the first frame update
    void Start()
    {

            audioSource = GetComponent<AudioSource>();
       
    }
   

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SoftFloor")
        {
            audioSource.clip = footstepSoft;
        }
        else if(other.tag == "HardFloor")
        {
            audioSource.clip = footstepHard;
        }
    }




    public void FootStepSound()
    {
        audioSource.Play();
    }
}
