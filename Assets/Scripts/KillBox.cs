using UnityEngine;
using System.Collections;

public class KillBox : MonoBehaviour {

	// Use this for initialization


	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			Bomb bomb = other.GetComponent<Bomb>();
			if(bomb != null)
			{
				bomb.Reset();
			}
		}
		
		if (other.gameObject.CompareTag("Player"))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}

