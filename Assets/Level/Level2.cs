using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    int Levellock;
    public Button[] levelbuttons;
    // Start is called before the first frame update
    void Start()
    {
        Levellock = PlayerPrefs.GetInt("Levellock", 1);

        for (int  i = 0; i< levelbuttons.Length; i++)
        {
            levelbuttons[i].interactable = false;
        }

        for (int i =0; i< levelbuttons.Length; i++)
        {
            levelbuttons[i].interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
