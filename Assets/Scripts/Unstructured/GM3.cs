using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM3 : MonoBehaviour
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
        Instantiate(objects, new Vector3(6.200559f, 4.585839f, -1.429774f), Quaternion.identity);
    }
}
