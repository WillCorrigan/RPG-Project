using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



namespace RPG.Core
{ 
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;

        private void LateUpdate()
        {
            transform.position = target.position;
        }
    }
}

