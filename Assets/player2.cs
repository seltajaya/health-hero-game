using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public float kecepatan, scaleX, lompat, nyawa;
    public AudioSource buttonSound;
    //win or lose
    public GameObject UI_Lose;
    public GameObject pause;
    public GameObject tombol;


    // Start is called before the first frame update
    void Start()
    {
        scaleX = transform.localScale.x;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Deadly")
        {
            musik();
            nyawa -= 0.07f;
            if (nyawa < 0f)
            {

                gameObject.SetActive(false);
                UI_Lose.SetActive(true);
                pause.SetActive(false);
            }
        }
        if (collision.tag == "Bos")
        {
            musik();
            nyawa -= 0.07f;
            if (nyawa < 0f)
            {

                gameObject.SetActive(false);
                UI_Lose.SetActive(true);
                pause.SetActive(false);
            }
        }
    }

    public void jalan_kiri()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            GetComponent<Animator>().SetTrigger("jalan");
        }

        else if (gameObject.transform.position.x > -175f)
        {
            transform.localScale = new Vector3(-scaleX, transform.localScale.y, transform.localScale.z);
            transform.Translate(Vector3.left * kecepatan * Time.fixedDeltaTime, Space.Self);
        }
    }

    public void jalan_kanan()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            GetComponent<Animator>().SetTrigger("jalan");
        }

        else if (gameObject.transform.position.x < 960f)
        {
            transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
            transform.Translate(Vector3.right * kecepatan * Time.fixedDeltaTime, Space.Self);
        }
    }

    public void jalan_atas()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            GetComponent<Animator>().SetTrigger("jalan");
        }
        //GetComponent<Rigidbody2D>().velocity = new Vector2(0, lompat);//
        else if (gameObject.transform.position.y < -30f)
        {
            transform.Translate(Vector3.up * kecepatan * Time.fixedDeltaTime, Space.Self);

        }

    }

    public void jalan_bawah()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            GetComponent<Animator>().SetTrigger("jalan");
        }
        else if (gameObject.transform.position.y > -160f)
        {

            //GetComponent<Rigidbody2D>().velocity = new Vector2(0, lompat);//
            transform.Translate(-Vector3.up * kecepatan * Time.fixedDeltaTime, Space.Self);
        }


    }

    public void berhenti()
    {
        GetComponent<Animator>().SetTrigger("stop");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            jalan_kiri();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            jalan_kanan();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            jalan_atas();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            jalan_bawah();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            berhenti();
        }

    }
    public void musik()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
    }

}
