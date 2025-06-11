using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //namespace ini kita butuhkan agar dapat memanggil fungsi yang ada pada class SceneManagement
using UnityEngine.UI;


public class Loading : MonoBehaviour
{
    /*public image.loadingfill;

        void start()
    {
        startCoroutine(Loading());
    }
    IEnumerator Loading()
    {
        AsyncOperation loading = SceneManager.LoadSceneAsync("Menu");

        while (!loading.isDone)
        {
            loadingfill.fillAmount = loading.progress/0.9f;
            
            yield return null;
        }
    }*/

    public void load()
    {
        SceneManager.LoadScene("Menu");

    }
}
