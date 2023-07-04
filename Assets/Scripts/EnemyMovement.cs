using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject[] wayPoints;
    [SerializeField] int currentPoint;
    [SerializeField] float speed;
    [SerializeField] float tes;


    void Update()
    {
        tes = Vector3.Distance(transform.position, wayPoints[currentPoint].transform.position);
        if (Vector3.Distance(transform.position, wayPoints[currentPoint].transform.position) <= .1f)
        {
            currentPoint++;
            if (currentPoint >= wayPoints.Length)
            {
                currentPoint = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentPoint].transform.position, speed * Time.deltaTime);

        // Determine which direction to rotate towards
        Vector3 targetDirection = wayPoints[currentPoint].transform.position - transform.position;

        // The step size is equal to speed times frame time.
        float singleStep = speed * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        // Draw a ray pointing at our target in
        Debug.DrawRay(transform.position, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);

    }
}
