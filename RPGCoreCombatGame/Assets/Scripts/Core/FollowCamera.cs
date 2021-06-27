using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    private Transform playerObject;

    void LateUpdate()
    {
        transform.position = playerObject.transform.position;
    }
}
