using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Declump : MonoBehaviour
{
    private NavMeshAgent agent2;
    public GameObject center;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("West"))
        {
            agent2 = this.GetComponent<NavMeshAgent>();
            agent2.SetDestination(center.transform.position);
        }
    }
}