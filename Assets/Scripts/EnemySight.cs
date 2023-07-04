using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySight : MonoBehaviour
{
    [SerializeField] LayerMask layer;
    [SerializeField] float radius;
    [SerializeField] float maxDistance;
    RaycastHit hit;
    void Update()
    {
        cast();
    }
    
    void cast()
    {
        if(Physics.SphereCast(transform.position, radius, transform.forward* maxDistance, out hit))
        {
            if(hit.collider.gameObject.layer ==7 )
            {
                Debug.Log(hit.collider.gameObject);
                Time.timeScale = 0;
            }
        }
    }
}
