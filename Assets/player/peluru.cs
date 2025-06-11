using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluru : MonoBehaviour
{
    float scale_karakter;
    public int damage = 40;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        scale_karakter = GameObject.Find("artis2").transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (scale_karakter == 5.212381f)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(1000f, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1000f, GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.name == "batas 1" || obj.gameObject.name == "batas 2" || obj.gameObject.name == "Slimey" || obj.gameObject.name == "Bos" || obj.tag == "Deadly" || obj.tag == "Bos")
        {
            Destroy(gameObject);
        }
    }
    /*void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }*/

}
