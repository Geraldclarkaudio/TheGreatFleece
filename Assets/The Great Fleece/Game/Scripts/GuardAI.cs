using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{

    public List<Transform> wayPoints;

    private NavMeshAgent _agent;

    private bool reverse;
    private bool targetReached;
    private Animator _anim;
    [SerializeField]
    private int currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(wayPoints.Count > 0 && wayPoints[currentTarget] != null)
        {
            _agent.SetDestination(wayPoints[currentTarget].position);
        

            float distance = Vector3.Distance(transform.position, wayPoints[currentTarget].position);

            if(distance < 1.0f && (currentTarget == 0 || currentTarget == wayPoints.Count - 1))
            {
                if(_anim != null)
                {
                    _anim.SetBool("Walk", false);
                }
            }
            else
            {
                if (_anim != null)
                {
                    _anim.SetBool("Walk", true);
                }
            }

            if(distance < 1.0f && targetReached == false)
            {
                if ((currentTarget == 0 || currentTarget == wayPoints.Count - 1) && wayPoints.Count > 1)
                {
                    targetReached = true;
                    Debug.Log("Target Reached: " + targetReached);

                    StartCoroutine(WaitBeforeMoving());
                }
                else
                {
                    if(wayPoints.Count > 1)
                    {
                        if (reverse == true)
                        {
                            currentTarget--;
                            if (currentTarget <= 0)
                            {
                                reverse = false;
                                currentTarget = 0;
                            }
                        }
                        else
                        {
                            currentTarget++;
                        }
                    }
                    
                }                          
            }
        }
    }

    IEnumerator WaitBeforeMoving()
    {

        if (currentTarget == 0)
        {
            yield return new WaitForSeconds(2.0f);
        }
        else if (currentTarget == wayPoints.Count - 1)
        {
            yield return new WaitForSeconds(2.0f);
        }
        else
        {
            yield return null;
        }

            if(reverse == true)
            {
                currentTarget--;

                if (currentTarget == 0)
                {
                    reverse = false;
                    currentTarget = 0;
                }
            }
            else if(reverse == false)
            {
                currentTarget++;

                if (currentTarget == wayPoints.Count)
                {
                    reverse = true;
                    currentTarget--;
                }
            }

           targetReached = false;
             
    }
        

}
