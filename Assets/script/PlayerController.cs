using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Transform spawnPoint;

	private Rigidbody rb;

	void Start () {		//called when this class is initialized
		rb = GetComponent<Rigidbody>();		//gets the rigid body for this object
	}

	void Update() {
		for (int i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch(i).phase == TouchPhase.Began) {
				transportPlayer();
				break;
			}
		}

		if(Input.GetKeyDown ("space")) {
			transportPlayer();
		}
		Vector3 currPos = rb.transform.position;

		//		float x = 10 * Mathf.Sin(2 * Mathf.PI * frameCount / 120);
		float x = Mathf.Sin (Time.time * 4) * 2.5f;

		rb.transform.position = new Vector3 (x, currPos.y, currPos.z);
	}

	void FixedUpdate () {		//fixed update called incramentally to do physics stuff



//		if (Input.GetKeyDown ("space")) {		//if you hit space bar can jump
//			print ("space bar pressed!");
////			Vector3 jump = new Vector3(0, jumpForce, 0);
////			rb.AddForce(jump);								//add the force
//		}
	}

	private void transportPlayer() {
		Vector3 currPos = rb.transform.position;
		rb.transform.position = spawnPoint.position;//new Vector3(spawnPoint.position.x, currPos.y, currPos.z);

		spawnPoint.position = currPos;
	}

}