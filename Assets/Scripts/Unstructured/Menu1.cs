using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu1 : MonoBehaviour
{
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
        
    {
     
    }

public void Play()
{
        
    SceneManager.LoadScene(2);
}

public void Quite()
{
    Application.Quit();
}
}
