using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroling : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints
    public float speed = 2f; // Patrol speed
    public float waypointRadius = 0.1f; // Radius to consider as reached the waypoint

    private int currentWaypointIndex = 0;

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        if (waypoints.Length == 0); 

        // Move towards the current waypoint
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector2 direction = (targetWaypoint.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        // Check if the enemy has reached the waypoint
        if (Vector2.Distance(transform.position, targetWaypoint.position) < waypointRadius)
        {
            // Move to the next waypoint
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
