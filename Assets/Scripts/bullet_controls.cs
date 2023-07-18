using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bullet_controls : MonoBehaviour
{
    float bullet_speed;

    public Rigidbody2D rb;

    bool isOut = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bullet_speed = 7.5f;
        bullet_move();

        if (isOut == true)
        {
            Destroy(gameObject);
        }
    }

    void bullet_move()
    {
        rb.velocity = new Vector2(0.0f, bullet_speed);

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OUT");
    }



}
