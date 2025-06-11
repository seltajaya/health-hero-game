using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //namespace ini kita butuhkan agar dapat memanggil fungsi yang ada pada class SceneManagement

public class Level : MonoBehaviour
{
    public bool paused;
    public AudioSource buttonSound;
    public GameObject next;
    public GameObject tombol;

    void Start()
    {
        
    }
    public void PauseGame()
    {
        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
    }
    // Start is called before the first frame update
    
    public void Level1()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        
            SceneManager.LoadScene("Level1");
            Time.timeScale = 1;
            musik();
        
        
    }

    public void Level2()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        if (PlayerPrefs.GetInt("Level") >= 2)
        {
            SceneManager.LoadScene("Level2");
            SceneManager.GetActiveScene();
            Time.timeScale = 1;
            musik();
        }
            
    }

    public void Level3()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        if (PlayerPrefs.GetInt("Level") >= 3)
        {
            SceneManager.LoadScene("Level3");
            SceneManager.GetActiveScene();
            Time.timeScale = 1;
            musik();
        }
    }

    public void Level4()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        if (PlayerPrefs.GetInt("Level") >= 4)
        {
            SceneManager.LoadScene("Level4");
            
            Time.timeScale = 1;
            musik();
        }
    }

    public void Level5()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        if (PlayerPrefs.GetInt("Level") >= 5)
        {
            SceneManager.LoadScene("Level5");

            Time.timeScale = 1;
            musik();
        }
    }
    public void Level6()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        if (PlayerPrefs.GetInt("Level") >= 6)
        {
            SceneManager.LoadScene("Level6");

            Time.timeScale = 1;
            musik();
        }
    }
    public void Level7()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        if (PlayerPrefs.GetInt("Level") >= 7)
        {
            SceneManager.LoadScene("Level7");

            Time.timeScale = 1;
            musik();
        }
    }
    public void Level8()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        if (PlayerPrefs.GetInt("Level") >= 8)
        {
            SceneManager.LoadScene("Level8");

            Time.timeScale = 1;
            musik();
        }
    }
    public void Level9()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        if (PlayerPrefs.GetInt("Level") >= 9)
        {
            SceneManager.LoadScene("Level9");

            Time.timeScale = 1;
            musik();
        }
    }
    public void Level10()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        if (PlayerPrefs.GetInt("Level") >= 10)
        {
            SceneManager.LoadScene("Level10");

            Time.timeScale = 1;
            musik();
        }
    }

    public void Next()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        if (PlayerPrefs.GetInt("Level") >= 11)
        {
            next.SetActive(true);
            tombol.SetActive(true);
        }
    }

    public void Kembali()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("Menu");
        musik();
    }
    public void Kembali2()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        next.SetActive(false);
        tombol.SetActive(false);
    }
    public void musik()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
    }
}
