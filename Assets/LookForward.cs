using UnityEngine;
using System.Collections;

public class LookForward : MonoBehaviour {

	public Transform sightStart, sightEnd;

	private bool collision = false;
	
	// Update is called once per frame
	void Update () {
        //cek tabrakan dengan objek memiliki layer bernama solid
		collision = Physics2D.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer ("Solid"));
		//menggambar garis debug gizmos
		Debug.DrawLine (sightStart.position, sightEnd.position, Color.green);

		if(collision) //jika tabrakan, maka gambar akan di flip dgn cara scale x=-1
			this.transform.localScale = new Vector3((transform.localScale.x == 1) ? -1 : 1, 1, 1);
	}
}
