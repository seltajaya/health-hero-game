using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bos : MonoBehaviour
{
    public Transform player;
    public float moveSpeed, nyawa, scaleX, kecepatan;
    private Rigidbody2D rb;
    private Vector2 movement;
    public int health = 100;
    public GameObject deathEffect;
    public Vector2 defaultscale;
    public AudioSource buttonSound;
    public AudioSource soundJalan;
    public GameObject Slimey2;
    public GameObject pause;
    public GameObject tombol1, tombol2, tombol3, tombol4, tombol5;
    public GameObject antek1, antek2, antek3, antek4;
    public GameObject UI_Win;
    public int nextLevel;


    /*public static int scoreValue = 0;
    public Text score;
    private float limitAddScores = 1;*/



    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Instantiate(deathEffect, new Vector3(Random.Range(521f, 780f), Random.Range(-100f, 35f), 0f), Quaternion.identity);
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").transform;
        defaultscale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.z, direction.y) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;*/
        Vector2 tempVector2 = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

        transform.position = new Vector3(tempVector2.x, tempVector2.y, transform.position.z);
        if (player.position.x > transform.position.x)
        {
            transform.localScale = defaultscale * new Vector2(-1f, 1f);
        }
        else
        {
            transform.localScale = defaultscale * new Vector2(1f, 1f);
        }
        GetComponent<Animator>().SetTrigger("jalan");


    }
    private void FixedUpdate()
    {
        //moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        GetComponent<Animator>().SetTrigger("jalan");


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "peluru")
        {
            nyawa -= 0.3f;
            if (nyawa < 0f)
            {
                dead();
            }


        }
        if (collision.tag == "Player")
        {
            GetComponent<Animator>().SetTrigger("serang");


        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
     
    }
    public void dead()
    {
        GetComponent<Animator>().SetTrigger("mati");

    }

    public void hilang()
    {
        name = "death";
        gameObject.SetActive(false);
        /*if (limitAddScores > 0)
        {
            limitAddScores = 0;
            score.text = "Score: " + scoreValue;
            ScoreScript.scoreValue += 10;
        }*/
        UI_Win.SetActive(true);
        Slimey2.SetActive(false);
        pause.SetActive(false);
        tombol1.SetActive(false);
        tombol2.SetActive(false);
        tombol3.SetActive(false);
        tombol4.SetActive(false);
        tombol5.SetActive(false);
        antek1.SetActive(false);
        antek2.SetActive(false);
        antek3.SetActive(false);
        antek4.SetActive(false);
        PlayerPrefs.SetInt("Level", nextLevel);

    }
    public void jalan()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
    }
    public void serang()
    {
        soundJalan.PlayOneShot(soundJalan.clip);
    }




}