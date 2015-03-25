using UnityEngine;
using System.Collections;

public class buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")) 
		{
			Application.LoadLevel("scene1"); 
			Destroy(gameObject);
		}
		if (Input.GetButton("Fire2"))
		{
			Application.LoadLevel("menu"); 
			Destroy(gameObject);

		}
	}
}
