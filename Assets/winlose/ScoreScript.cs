using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;
    public int TotalEnemyAlive;
    public GameObject[] Enemies;
    
    private float limitAddScores = 1;
    public GameObject Slimey2;
    public GameObject pause;
    public GameObject tombol1, tombol2, tombol3, tombol4, tombol5;
    public GameObject UI_Win;
    public int nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        //score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        AddScores();
        Enemies = GameObject.FindGameObjectsWithTag("Deadly") ;
        TotalEnemyAlive = 0;
        for (int a = 0; a < Enemies.Length; a++)
        {
            if(Enemies[a].activeSelf)
            {
                TotalEnemyAlive++;
            }
        }
        if(TotalEnemyAlive==0)
        {
            //ScoreScript.scoreValue += 10;
            UI_Win.SetActive(true);
            Slimey2.SetActive(false);
            pause.SetActive(false);
            tombol1.SetActive(false);
            tombol2.SetActive(false);
            tombol3.SetActive(false);
            tombol4.SetActive(false);
            tombol5.SetActive(false);
            if(PlayerPrefs.GetInt("Level") < nextLevel)
            {
                PlayerPrefs.SetInt("Level", nextLevel);
            }
            
        }
    }

    private void AddScores()
    {
        if (TotalEnemyAlive == 0)
        {
            if (limitAddScores > 0)
            {
                limitAddScores = 0;
                /*score.text = "Score: " + scoreValue;*/
                ScoreScript.scoreValue += 10;
            }
        }
        else
        {
            limitAddScores = 1;
        }
    }
}
