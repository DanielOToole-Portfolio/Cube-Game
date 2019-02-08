using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform lookAt;
	public Transform camTransform;

	private Camera cam;

	private float distance = 7.0f;
	private float currentX = 30.0f;
	private float currentY = 0.0f;


	private void Start()
	{
		camTransform = transform;
		cam = Camera.main;

	}

	private void LateUpdate()
	{
		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentX, currentY, 0);
		camTransform.position = lookAt.position + rotation * dir;
	}

}
