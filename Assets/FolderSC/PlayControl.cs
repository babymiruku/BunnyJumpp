using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControl : MonoBehaviour
{
    public float speed = 1.0f;

  

    Rigidbody2D rigidbody2d;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

    }


    private void Update()
    {
        Vector2 f = new Vector2(0,0);

        if(Input.GetKey(KeyCode.D))
        {
            f = new Vector2(speed,0);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            f = new Vector2(-speed,0);
        }
        
        rigidbody2d.AddForce(f);
    }


}