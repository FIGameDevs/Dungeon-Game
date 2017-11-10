using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float Speed = 3;
	float turnSmoothVelocity;

	void Update()
	{
		Vector2 input = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));

		if(input != Vector2.zero)
		{
			float targetRotation = Mathf.Atan2 (input.x, input.y) * Mathf.Rad2Deg;
			transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle (transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, 0.2f);
		}

		transform.Translate(transform.forward * input.normalized.magnitude * Time.deltaTime * Speed, Space.World);
	}
}
