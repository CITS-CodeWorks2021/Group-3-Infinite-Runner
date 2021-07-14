using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackgroundScroller : MonoBehaviour
{


    public BoxCollider2D Collider;
    public Rigidbody2D rb;
    private float width;
    private float scrollSpeed = -2f;
    private float startTime;
    public Text timerText;


    // Start is called before the first frame update
    void Start()
    {

        Collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = Collider.size.x;
        Collider.enabled = false;

        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(scrollSpeed, 0);

        if (transform.position.x < -width)
        {
            Vector2 ResetPos = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + ResetPos;
        }

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        if ((t % 60) > 15)
        {
            scrollSpeed = -3f;
        }

        if ((t % 60) > 25)
        {
            scrollSpeed = -5f;
        }

        if ((t % 60) > 40)
        {
            scrollSpeed = -7f;
        }

        if((t % 60) > 120)
        {
            scrollSpeed = -10f;
        }

        timerText.text = minutes + "." + seconds;
    }
}
