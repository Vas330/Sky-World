using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectMove : MonoBehaviour
{
    public float s;
    
    private void Start()
    {
        s = 0.05f;
    }

    
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - s, transform.position.y, 0);
        if (transform.position.x <= - 17.5f)
        {
            
        }
    }
}
