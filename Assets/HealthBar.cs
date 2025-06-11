using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject hero;

    void Start()
    {
        hero = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        transform.localScale = new Vector3(hero.GetComponent<player>().nyawa*0.0393f, 5.2255f, 5.2255f);
    }
}
