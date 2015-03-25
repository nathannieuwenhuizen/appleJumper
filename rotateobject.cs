using UnityEngine;
using System.Collections;

public class rotateobject : MonoBehaviour {
	public int startspeed;
	public int acceleration;
	private int counter;

	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward, (startspeed+(counter /300)) * Time.deltaTime);
		if (counter < 90000) 
		{
			counter = counter + acceleration;
		}
	}


	void OnCollisionEnter2D(Collision2D Collision) {
		if (Collision.gameObject.tag == "Player")
			Application.LoadLevel("scene1");
		
	}

}
