using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PatientState
{
	// ステートの実行を管理するクラス
	public class StateProcessor
	{
		// ステート本体
		private PatientState _State;
		public PatientState State { get; set; }

		// 実行ブリッジ
		public void Execute()
		{
			State.Execute();
		}
	}

	// ステートのクラス
	public abstract class PatientState
	{
		// デリゲート
		public delegate void executeState();
		public executeState execDelegate;

		// 実行処理
		public virtual void Execute()
		{
			if (execDelegate != null)
			{
				execDelegate();
			}
		}
	}

	// 以下状態クラス

	// 正常
	public class PatientStateNormal : PatientState
	{

	}

	// けが
	public class PatientStateInjury : PatientState
	{
		
	}
}

