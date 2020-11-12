using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;

    private void Start()
    {
        
    }

    void Update()
    {
        transform.position = target.position;
    }
}
