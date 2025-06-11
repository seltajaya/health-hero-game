using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //namespace ini kita butuhkan agar dapat memanggil fungsi yang ada pada class SceneManagement

public class about : MonoBehaviour
{
    public AudioSource buttonSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void musik()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
    }
    public void about2()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("about2");
        musik();
    }
    public void about1()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("about1");
        musik();
    }
    public void about3()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("about3");
        musik();
    }
    public void about4()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("about4");
        musik();
    }
    public void about5()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("about5");
        musik();
    }
    public void ok()
    {
        /*Memanggil fungsi LoadScene yg memiliki parameter bertipe string / int
         * harus kita isi dengan nama scene / index scene yang akan
         *dijadikan scene atau level selanjutnya*/
        SceneManager.LoadScene("Menu");
        musik();

    }
    

}
