using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase01 : MonoBehaviour
{

    private Transform playerTransform;
    private NavMeshAgent nav;

    public float moveSpeed = 5f; // the enemy's move speed
    public float rotationSpeed = 5f; // the speed at which the enemy rotates
    public float chaseRange = 10f; // the distance at which the enemy starts chasing the player
    public float deathRange = .75f; // the distance at which the enemy kills the player


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.destination = playerTransform.position;

    }


    private void ChasePlayer(float distance)
    {



        // if the distance is less than a certain threshold, move towards the player
        if (distance < chaseRange)
        {
            // calculate the direction towards the player
            Vector3 direction = (playerTransform.position - transform.position).normalized;

            // move the enemy towards the player
            transform.position += direction * moveSpeed * Time.deltaTime;

            // calculate the rotation towards the player
            Quaternion lookRotation = Quaternion.LookRotation(direction);

            // smoothly rotate towards the player
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
