using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

	public float speed = 7f;
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent <Rigidbody2D> ();
	}

	void Update () {
		float moveX = Input.GetAxis ("Horizontal");
		rb.MovePosition (rb.position + Vector2.right * moveX);

		if (Input.GetKeyDown (KeyCode.Space))
			rb.AddForce (Vector2.up * 5000);

	}
}