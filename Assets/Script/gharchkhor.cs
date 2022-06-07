using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gharchkhor : MonoBehaviour
{
    private Rigidbody2D mario;
    public float speed = 5;
    public float jump = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        mario = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float s = Input.GetAxisRaw("Horizontal");
        mario.velocity = new Vector2(s*speed,mario.velocity.y);

        if(Input.GetKeyDown(KeyCode.UpArrow))
       mario.velocity += Vector2.up*jump;
    
        {
            
        }
        
        
    }
}
