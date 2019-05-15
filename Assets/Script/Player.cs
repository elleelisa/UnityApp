using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    bool grounded = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(3, rb.velocity.y);
        if (Input.GetMouseButtonDown(0) && grounded) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2 (0f, 200f));
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        Debug.Log ("Collision Enter");
        if (col.gameObject.tag == "Ground") {
        grounded = true;
        }
    }

    void onCollisionExit2D(Collision2D col){
        Debug.Log ("Collision Exit");
        if (col.gameObject.tag == "Ground") { 
        grounded = false;
        }
    }
}
