using UnityEngine;
using System.Collections;

public class Paralax : MonoBehaviour {
	public Transform[] backgrounds; //array/list of all back and forgrounds to be paralax
	private float[] paralaxScales; //the scale of the movement of the camera that of the backgrounds.
	public float smoothing = 1f; //how smooth the paralax it will be, set it about 0

	private Transform cam; //reference to the main camera transform
	private Vector3 previousCamPos; //the position of the camera in the previous frame.


	//awake is called before start and it will call all the start objects but before the game begins
	void Awake(){
		cam = Camera.main.transform;
	}

	// Use this for initialization
	void Start () {
		previousCamPos = cam.position;

		paralaxScales = new float[backgrounds.Length];
		for (int i=0; i < backgrounds.Length; i++) {
			paralaxScales[i] = backgrounds[i].position.z*-1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=0; i< backgrounds.Length; i++) {
			float parallax = (previousCamPos.x - cam.position.x) * paralaxScales[i];

			float backgroundTargetPosX = backgrounds[i].position.x + parallax;

			Vector3 backgroundTargetPos = new Vector3 (backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

			backgrounds[i].position = Vector3.Lerp (backgrounds[i].position, backgroundTargetPos, smoothing *Time.deltaTime);
		}
		previousCamPos = cam.position;
	}
}
