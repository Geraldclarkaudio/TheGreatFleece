using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{

    //create a variable to hold nav mesh agent
    private NavMeshAgent _agent;

    // Start is called before the first frame update
    void Start()
    {
        //assign the handle to navmesh agent component
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // if left click

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

            }
        }

        //create an object at floor position .. 


    }
}
