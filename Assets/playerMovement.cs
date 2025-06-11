using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float jf;
    public float ms;
    public GameObject player, artis;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal"); // kiri, kanan
        Rb.velocity = new Vector2(ms * horiz, Rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            Rb.AddForce(new Vector2(0, jf));
        }
    }
    
   private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    /*void OnMouseDown()
    {
        player.GetComponent<Animator>().SetTrigger("jalan");
        artis.GetComponent<Animator>().SetTrigger("jalan");
    }*/
}
