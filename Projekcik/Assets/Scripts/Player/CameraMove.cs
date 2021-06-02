using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 1;
    public GameObject playerGO;

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, playerGO.transform.position, Time.fixedDeltaTime * speed);
    }
}
