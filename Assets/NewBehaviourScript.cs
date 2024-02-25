using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rd;
    Vector2 xdirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xdirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        rd.velocity = xdirection * 600* Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ASH")
        {
            Destroy(gameObject);
        }
    }
}
