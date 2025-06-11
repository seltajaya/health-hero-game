using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tembak : MonoBehaviour
{
    public GameObject peluru, pos_peluru;
    public AudioSource buttonSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        Instantiate (peluru, pos_peluru.transform.position, pos_peluru.transform.rotation);
        musik();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void musik()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
    }
}
