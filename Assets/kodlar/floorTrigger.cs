using UnityEngine;
using System.Collections;

public class floorTrigger : MonoBehaviour {

	Character cr;

	// Use this for initialization
	void Start () {
		cr = transform.root.gameObject.GetComponent<Character> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D() {

		cr.IsAtFloor = true;
	}

	void OnTriggerStay2D() {
		cr.IsAtFloor = true;
	}
	void OnTriggerExit2D() {
		cr.IsAtFloor = false;
	}
}
