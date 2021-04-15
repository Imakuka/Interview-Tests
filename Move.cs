using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewTesting
{
    public class Move : MonoBehaviour
    {

        [SerializeField]
        private Renderer _objRend;
        [SerializeField]
        private float _speed = 1.0f;

        // Start is called before the first frame update
        private void Start()
        {
            TargetDetection.onTargetExit += TargetExit;
        }

        // Update is called once per frame
        private void Update()
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }

        private void TargetExit(GameObject obj)
        {
            if (gameObject == obj)
            {
                _objRend.material.color = Color.green;
            }
        }

        private void OnDisable()
        {
            TargetDetection.onTargetExit += TargetExit;
        }
    }
}

