using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;

    [Header("移动参数")]
    public float speed = 2f;

    float xVelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GroundMovement();
    }

    void GroundMovement()
    {
        xVelocity = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed*xVelocity, rb.velocity.y);

        FlipDirection();
    }

    void FlipDirection()
    {
        if (xVelocity < 0)
            transform.localScale = new Vector2(-1, 1);
        if (xVelocity > 0)
            transform.localScale = new Vector2(1, 1);
    }

    void SwitchScene()
    {
        SceneManager.LoadScene("Drink");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "npc" && Input.GetKey(KeyCode.W))
        {
            SwitchScene();
        } 
    }
}
