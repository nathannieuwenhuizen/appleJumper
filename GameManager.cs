using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
    public Text CollectableText;
	private bool p =false;
	static int nrOfCollectedItems = 0;
	// Use this for initialization

	void Start()
	{
	
		nrOfCollectedItems = 0;
		p = false;

	}

	public void True()
	{
		p = true;
	}
	public void False()
	{
		p = false;
	}

	void UpdateUI()
	{
		CollectableText.text = nrOfCollectedItems.ToString();

	}
	void Update()
	{
		 
		if (p == true) {
			nrOfCollectedItems++;						
			UpdateUI ();
			}
		}
}
