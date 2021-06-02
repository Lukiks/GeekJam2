using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timer = 3f;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
            Destroy(gameObject);
    }
}
