using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	Vector3 startingPosition;
	Rigidbody2D rbody;

	// Use this for initialization
	void Start () {
		startingPosition = transform.position;
		rbody = GetComponent<Rigidbody2D> ();
	}

	public void Reset()
	{
		transform.position = startingPosition;
		rbody.velocity = Vector2.zero;
	}
}
