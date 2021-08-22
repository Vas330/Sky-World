using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM2 : MonoBehaviour
{
    public GameObject objects;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObjects", 1, 1);
    }

    // Update is called once per frame
    void CreateObjects()
    {
        Instantiate(objects, new Vector3(9.91f, 1.8f, 0f), Quaternion.identity);
    }
}