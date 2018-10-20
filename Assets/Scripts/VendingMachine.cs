using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingMachine : MonoBehaviour {

	public GameObject foodObj;
	public bool isBuy;

	[SerializeField]
	private float power;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isBuy){
			GameObject a = Instantiate(foodObj,transform.position,Quaternion.identity);
			Vector3 force = transform.forward + transform.up;
			a.GetComponent<Rigidbody>().AddForce(force * power);
			isBuy = false;
		}
	}
}
