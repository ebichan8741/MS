﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		FadeManager.FadeIn();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			FadeManager.FadeOut(0);
		}
	}
}