using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //namespace ini kita butuhkan agar dapat memanggil fungsi yang ada pada class SceneManagement



public class MainMenu : MonoBehaviour
{
    public AudioSource buttonSound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Kondisi ketika ada Input dari keyboard
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();     //Fungsi untuk keluar dari game / aplikasi
            Debug.Log("Quit Game"); //Mencetak output string pada Console
        }
    }


    //Membuat fungsi agar dapat berpindah scene dengan nama MainGame
    public void MainGame()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("level_dua");
        musik();
    }
    public void Leveksatu()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("Cutscene");
        //SceneManager.LoadScene("level_satu");
        musik();
    }
    public void aboutgame()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("aboutgame");
        musik();
    }
    public void Keluar()
    {
        Application.Quit();     //Fungsi untuk keluar dari game / aplikasi
        Debug.Log("Quit Game"); //Mencetak output string pada Console
        musik();
    }
    public void musik()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
    }
}