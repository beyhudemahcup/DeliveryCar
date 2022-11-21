using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    
    //follow camera's position should be the same as car's position
    [SerializeField] GameObject thingToFollow;
    void Update()
    {
        Vector3 followVector = new Vector3(0,0,-10);
        transform.position = thingToFollow.transform.position + followVector;
    }
}
