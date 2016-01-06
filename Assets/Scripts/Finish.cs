using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {
	public bool exit = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int i = Application.loadedLevel;
		if (exit == true)
		{
		
			if (Input.GetKeyDown("e"))
		
			{
				Application.LoadLevel(i + 1);
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			exit = true;
		}
	}
}
