using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class darah : MonoBehaviour
{
    public GameObject Bos1;
    // Start is called before the first frame update
    void Start()
    {
        Bos1 = GameObject.FindWithTag("Bos");
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(Bos1.GetComponent<Bos>().nyawa * 0.0393f, 5.2255f, 5.2255f);
    }
}
