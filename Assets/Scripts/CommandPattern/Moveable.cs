using System;
using UnityEngine;

public class Moveable : MonoBehaviour {

	public void moveForward() {
		Vector3 position = transform.position;
		position.y += Config.MOVE_VALUE;
		transform.position = position;
	}

	public void moveBackward() {
		Vector3 position = transform.position;
		position.y -= Config.MOVE_VALUE;
		transform.position = position;
	}

	public void moveLeft() {
		Vector3 position = transform.position;
		position.x -= Config.MOVE_VALUE;
		transform.position = position;
	}

	public void moveRight() {
		Vector3 position = transform.position;
		position.x += Config.MOVE_VALUE;
		transform.position = position;
	}
}


