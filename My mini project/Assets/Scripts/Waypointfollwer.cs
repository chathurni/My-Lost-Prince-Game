using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypointfollwer : MonoBehaviour
{

    [SerializeField] private GameObject [] waypoints;
    private int currentWaypointIndex   =0;

    [SerializeField] private float speed =2f;


    private void Update()
    {
        if(Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) <.1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex>=waypoints.Length)
            {
                transform.eulerAngles = new Vector3 (0,180,0);
                currentWaypointIndex = 0;
                
               
            }else if (currentWaypointIndex<waypoints.Length)
            {

                transform.eulerAngles = new Vector3 (0,0,0);
            }
             
        }

        transform.position = Vector2.MoveTowards(transform.position,waypoints[currentWaypointIndex].transform.position,Time.deltaTime*speed);

        
    }

    
}
