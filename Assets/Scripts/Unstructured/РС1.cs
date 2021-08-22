using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class РС1 : MonoBehaviour
{
    public GameObject gameOver;
    public Text live;
    public int liveScore = 3;
    public Transform groundCheck;
    public LayerMask groundMask;
    private bool ground = false;
    private float groundRadius = 0.5f;

    private void Start()
    {

    }

    private void Update()

    {
        ground = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);
        if (Input.GetMouseButtonDown(0) && ground == true)
        {
            Jump();
        }

        if (liveScore == 0)
        {
            gameOver.SetActive(true);
        }


    }
    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300));
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            liveScore--;
            live.text = liveScore.ToString();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Vulcan");
    }

}
