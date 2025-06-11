using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public float speed = .5f;    
    private Rigidbody2D rigidbody2D;
    /*public GameObject target; //target yang dikejar
    public float movingSpeed = 2f; //kecepatan berpindah
    public float turnSpeed = 0.05f; //kecapatan berbelok*/

    void Start(){
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {//memberikan nilai speed kepada sumbu x
		rigidbody2D.velocity = new Vector2 (transform.localScale.x, 0) * speed;
        /*Vector3 gapPosition = target.transform.position - this.transform.position; //Gap antara posisi AI dengan target
        gapPosition = new Vector3(gapPosition.x, 0, gapPosition.z); //Nilai gap y dibuat 0 agar AI mengabaikan posisi atas dan bawah (Y) dari target dan hanya mengikuti arah ke kanan dan ke kiri (X dan Y)
        Quaternion lookRotation = Quaternion.LookRotation(gapPosition); //Rotasi untuk look atau melihat target
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, lookRotation, turnSpeed); //Membuat rotasi berubah secara smooth menggunakan fungsi lerp dari rotasi awal ke rotasi tujuan lookRotasion

        this.transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime); //Bergerak maju*/
    }
}
