using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour {

	// スタートボタンが押されたフラグ
	public static bool onButton = false;
	// フェードまでのインターバル用
	private float count = 0;

	// Use this for initialization
	void Start () {
		onButton = false;
		count = 0;
		FadeManager.FadeIn();
	}

	// Update is called once per frame
	void Update()
	{
		if (onButton)
		{
			count += Time.deltaTime;
			if (count >= 1) FadeManager.FadeOut(1);
		}
	}

}
