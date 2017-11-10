using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float Speed = 1;


	void Update()
	{
		print (Input.GetAxis ("Horizontal"));
		transform.Translate (Time.deltaTime * Input.GetAxis ("Horizontal")*Speed, 0, Time.deltaTime*Input.GetAxis("Vertical")*Speed);
	}
}
