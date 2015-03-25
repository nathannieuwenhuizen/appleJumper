using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Update () {
		DontDestroyOnLoad(transform.gameObject);
	}
}
