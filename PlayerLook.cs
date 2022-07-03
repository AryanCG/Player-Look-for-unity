using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {
	// Variables
	private float Sensitiviy = 100f;
	public Transform Player;
	float Xrotation = 0f;

	void Update()
	{
		playerlook();
		//locking our cursor in game
		Cursor.lockState = CursorLockMode.Locked;
	}

	void playerlook()
	{
		//Input for Player look Mouse X And Y are by default for unity
		float mouseX = Input.GetAxis("Mouse X") * Sensitiviy * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * Sensitiviy * Time.deltaTime;

		Xrotation -= mouseY;
		
		//Clamping the rotation
		Xrotation = Mathf.Clamp(Xrotation, -90f,90f);
		
		//rotating our player body
		transform.localRotation = Quaternion.Euler(Xrotation,0f,0f);

		Player.Rotate(Vector3.up * mouseX);
}
}
