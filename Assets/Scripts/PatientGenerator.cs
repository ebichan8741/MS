using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientGenerator : MonoBehaviour {

	public GameObject patient_smallInjury;
	public GameObject patient_mediumInjury;
	public GameObject patient_largeInjury;

	private float RandomRange_x = 50.0f;
	private float RandomRange_z = 50.0f;

	// Use this for initialization
	void Start () {

		int spawnRate = 0;
		GameObject patient;

		for(int i = 0;i < 20; i++)
		{
			// 患者の生成確率
			spawnRate = Random.Range(0, 10);
			// 軽傷
			patient = patient_smallInjury;
			// 中傷
			if (spawnRate >= 4 && spawnRate <= 8)
			{
				patient = patient_mediumInjury;
			}// 重傷
			else if (spawnRate > 8)
			{
				patient = patient_largeInjury;
			}

			Instantiate(patient, new Vector3(Random.Range(0, RandomRange_x), 2.0f, Random.Range(0, RandomRange_z)), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
