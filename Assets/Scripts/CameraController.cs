using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;

    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
