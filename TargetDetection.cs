using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace InterviewTesting
{
    public class TargetDetection : MonoBehaviour
    {
        public static event Action<GameObject> onTargetExit;

        [SerializeField]
        private List<GameObject> _activeTargets = new List<GameObject>();

        private void OnTriggerEnter(Collider other)
        {
            _activeTargets.Add(other.gameObject);
        }
        private void OnTriggerExit(Collider other)
        {
            _activeTargets.Remove(other.gameObject);
            if (onTargetExit != null)
            {
                onTargetExit(other.gameObject);
            }
        }
    }


}

