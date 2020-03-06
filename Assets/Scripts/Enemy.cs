using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;

    float speed = 3f;

    void Update()
    {
        Vector3 direction = player.position - transform.position;

        transform.position += direction.normalized * speed * Time.deltaTime;
        transform.up = direction.normalized;
    }
}
