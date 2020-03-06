using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    public Transform head;

    public float speed = 5.0f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direction = (transform.right * h + transform.up * v).normalized;
        transform.position += direction * speed * Time.deltaTime;

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 headDirection = new Vector3(mousePos.x, mousePos.y, 0f);

        head.transform.up = (headDirection - transform.position).normalized;


        RaycastHit2D hit;

        hit = Physics2D.Raycast(head.position, head.up, 10f);

        if (hit)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(hit.transform.gameObject);
                Debug.Log("발사");
            }

            Debug.DrawRay(head.position, head.up * Vector2.Distance(head.up, hit.transform.position));
        }
        else
        {
            Debug.DrawRay(head.position, head.up * 10f);
        }
    }
}
