using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	// Use this for initialization
	public float Speed,maxSpeed,JumpPower,tempSpeed;
	public bool IsAtFloor;

	Rigidbody2D CharacterWeight;
	Animator mover;
	void Start () {
		CharacterWeight = GetComponent<Rigidbody2D> ();
		mover = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && IsAtFloor){

			CharacterWeight.AddForce(Vector2.up * JumpPower);



		}
	}

	void FixedUpdate() {

		float s = Input.GetAxis("Horizontal");
		CharacterWeight.AddForce (Vector3.right * s * Speed);
		mover.SetBool ("isAtFloor",IsAtFloor);
		mover.SetFloat ("Speed",Mathf.Abs(s));

		if (s > 0.1f) {
			transform.localScale = new Vector2 (1,1);
		}
		if (s < -0.1f) {
			transform.localScale = new Vector2 (-1,1);
		}

		if (CharacterWeight.velocity.x > maxSpeed) {
			CharacterWeight.velocity = new Vector2 (maxSpeed, CharacterWeight.velocity.y);
		}
		if (CharacterWeight.velocity.x < -maxSpeed) {
			CharacterWeight.velocity = new Vector2 (-maxSpeed, CharacterWeight.velocity.y);
		}
	}
}
