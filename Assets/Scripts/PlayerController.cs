using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horiz, vert;
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Jump");
        Debug.Log(horiz);

        Vector2 newVelocity = new Vector2(horiz, vert);

        GetComponent<Rigidbody2D>().velocity = newVelocity * 5;

    }
}
