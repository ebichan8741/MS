using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

	[SerializeField]
	private float life_s;
	private float count = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		count += Time.deltaTime;
		if (count >= life_s) Destroy(gameObject);
	}

}
