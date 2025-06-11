using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject panelpause;
    public GameObject Slimey2;
    public GameObject tombol;

    public void PauseControl()
    {
        if(Time.timeScale == 1)
        {
            panelpause.SetActive(true);
            Time.timeScale = 0;
            Slimey2.SetActive(false);
        }
        else 
        { 
            Time.timeScale = 1;
            panelpause.SetActive(false);
            Slimey2.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        ScoreScript.scoreValue = 0;
    }

    public void MenuUtama()
    {
        Application.LoadLevel("Menu");
    }
}