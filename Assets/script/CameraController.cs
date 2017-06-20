using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;			//referece to the Player
	private Vector3 offset;				//vector to hold the offset
	private float smoothing = 5f;

	void Start () {						//called when class intantsiates
		offset = transform.position - player.transform.position;
	}

	void FixedUpdate() {
		Vector3 currPos = transform.position;
		Vector3 targetCamPos = new Vector3(currPos.x, player.transform.position.y + offset.y, currPos.z);
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
	}
}
