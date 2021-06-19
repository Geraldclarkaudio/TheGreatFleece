using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent _agent;

    private Animator _anim;

    private Vector3 _target;

    [SerializeField]
    private GameObject coinPrefab;
    [SerializeField]
    private AudioClip coinDrop;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //cast a ray from mouse position

            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                //debug position floor position hit.
                Debug.Log("Hit: " + hitInfo.point);

                //handle.destination = hit info point.. 
                _agent.SetDestination(hitInfo.point);

                //setbool walk to true
                _anim.SetBool("Walk", true);
                _target = hitInfo.point;
            }
        }

        float distance = Vector3.Distance(transform.position, _target);

        if (distance < 1.0f)
        {
            _anim.SetBool("Walk", false);
        }

        if(Input.GetMouseButtonDown(1))
        {
            Ray rayOrigin1 = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo1;

            if(Physics.Raycast(rayOrigin1, out hitInfo1))
            {
                Debug.Log("Right clicked at: " + hitInfo1.point);
                Instantiate(coinPrefab, hitInfo1.point, Quaternion.identity);
                AudioSource.PlayClipAtPoint(coinDrop, hitInfo1.point);
            }
        }


    }
}
