using UnityEngine;
using System.Collections;

public class moveplatform : MonoBehaviour {
	private float speed= -0.0005f;
	private float startspeed= 0.03f;
	public int edgepos;
	// Use this for initialization
	void Start () {




	}
	
	// Update is called once per frame
	void Update () {


		if (transform.position.x > edgepos) 
		{
			startspeed = startspeed + speed;
		}
		else if ( transform.position.x < -edgepos)
		{
			startspeed = startspeed -speed;
		}





		Vector3 position = this.transform.position;
		position.x += startspeed;
		this.transform.position = position;




	}
}
