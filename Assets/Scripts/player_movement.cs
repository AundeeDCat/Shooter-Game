using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    //public Animator player_move;
    public Rigidbody2D rb;
    public static float smooth = 5.0f;
    public static float angle = 0.0f;

    public static float speed = 5.0f;
    public static float x_move = -1;
    public static float y_move = -1;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        x_move = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(x_move, 0.0f);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            float curr_x = rb.position.x;
            float curr_y = rb.position.y;

            GameObject bullets = Instantiate(bullet);
            bullets.transform.position = new Vector2(curr_x, curr_y);
        }
    }
}
