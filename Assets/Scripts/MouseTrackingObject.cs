using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrackingObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 headDirection = new Vector3(mousePos.x, mousePos.y, 0f);
        transform.position = headDirection;
    }
}
