using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using PatientState;

public class PatientController : MonoBehaviour {

	//ステート
	public StateProcessor StateProcessor = new StateProcessor();				// プロセッサー
	public PatientStateNormal StateNormal = new PatientStateNormal();           // 正常
	public PatientStateInjury StateInjury = new PatientStateInjury();           // けが

	private float destroy_interval = 1.0f;
	private float count = 0;
	private bool isMedical = false;

	void Start () {
		// 初期状態
		StateProcessor.State = StateInjury;
		StateNormal.execDelegate = Normal;
		StateInjury.execDelegate = Injury;

	}

	void Update () {
		
		// nullチェック
		if(StateProcessor.State == null)
		{
			return;
		}// 正常
		else if(StateProcessor.State == StateNormal)
		{
			StateProcessor.Execute();
		}// けが
		else if(StateProcessor.State == StateInjury)
		{
			StateProcessor.Execute();
		}
	}

	// 正常
	public void Normal()
	{
		// 一定時間で破棄
		count += Time.deltaTime;
		if (count >= destroy_interval)
		{
			count = 0;
			Destroy(gameObject);
		}
	}

	// けが
	public void Injury()
	{
		// 治療したら正常状態に遷移
		if (isMedical)
		{
			StateProcessor.State = StateNormal;
			GetComponent<Renderer>().material.color = Color.cyan;
		}

	}

	private void OnTriggerEnter(Collider col)
	{
		isMedical = true;
		Debug.Log("あたった");
	}
}
