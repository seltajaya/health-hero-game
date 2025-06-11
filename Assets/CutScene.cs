using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //namespace ini kita butuhkan agar dapat memanggil fungsi yang ada pada class SceneManagement

public class CutScene : MonoBehaviour
{
    public float CutsceneTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CutsceneTimer -= Time.deltaTime;
        if(CutsceneTimer < 0f)
            SceneManager.LoadScene("level_satu");
        if(Input.GetMouseButton(0))
            SceneManager.LoadScene("level_satu");
    }
}
