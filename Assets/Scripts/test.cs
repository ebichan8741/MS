using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	public float speed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += transform.forward * speed;
		}
		else if (Input.GetKey(KeyCode.S))
		{
			transform.position -= transform.forward * speed;
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.position -= transform.right * speed;
		}
		else if (Input.GetKey(KeyCode.D))
		{
			transform.position += transform.right * speed;
		}
		if (Input.GetKey(KeyCode.Q))
		{
			transform.position -= transform.up * speed;
		}
		else if (Input.GetKey(KeyCode.E))
		{
			transform.position += transform.up * speed;
		}
	}
}
