using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
	public float moveSpeed = 2f;
	private Rigidbody2D rb2d;

	public BoxCollider2D boxCol;
	public float fallDelay = 1f;
	// Use this for initialization
	void Awake () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		rb2d.velocity = new Vector2(rb2d.velocity.x, transform.localScale.y * moveSpeed);	

	}
	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Invoke ("Fall", fallDelay);
		}

	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Wall")) 
		{
			Flip ();
		}
	}
	
	public void Flip()
	{
		// Multiply the x component of localScale by -1.
		moveSpeed *= -1;
	
	}

	
	void Fall()
	{
		moveSpeed = -10;
		rb2d.isKinematic = false;
		boxCol.enabled = false;
	}
}

