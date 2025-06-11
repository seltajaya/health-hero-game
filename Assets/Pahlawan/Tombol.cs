using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tombol : MonoBehaviour
{
    public GameObject player;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*void OnMouseDown()
    {
        if (gameObject.name == "kiri")
        {

        } else if (gameObject.name == "kanan")
        {

        } *//*else if (gameObject.name == "atas")
        {
            player.GetComponent<player>().jalan_atas();
        }
        else if (gameObject.name == "bawah")
        {
            player.GetComponent<player>().jalan_bawah();
        }*//*
    }*/
    void OnMouseUp()
    {
        if (gameObject.name == "kiri")
        {
            player.GetComponent<player>().berhenti();
        }
         if (gameObject.name == "kanan")
        {
            player.GetComponent<player>().berhenti();
        }
         if (gameObject.name == "atas")
        {
            player.GetComponent<player>().berhenti();
        }
         if (gameObject.name == "bawah")
        {
            player.GetComponent<player>().berhenti();
        }
    }
    void OnMouseDrag()
    {
        if (gameObject.name == "kiri")
        {
            player.GetComponent<player>().jalan_kiri();
            
        }
         if (gameObject.name == "kanan")
        {
            player.GetComponent<player>().jalan_kanan();
            
            
        }
         if (gameObject.name == "atas")
        {
            player.GetComponent<player>().jalan_atas();
            
        }
         if (gameObject.name == "bawah")
        {
            player.GetComponent<player>().jalan_bawah();
            
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
