using UnityEngine;
using System.Collections;

//キューブオブジェクトのステート
namespace TextState
{

	//ステートの実行を管理するクラス
	public class StateProcessor
	{
		//ステート本体
		private TextState _State;
		public TextState State
		{
			set { _State = value; }
			get { return _State; }
		}

		// 実行ブリッジ
		public void Execute()
		{
			State.Execute();
		}

	}

	//ステートのクラス
	public abstract class TextState
	{
		//デリゲート
		public delegate void executeState();
		public executeState execDelegate;

		//実行処理
		public virtual void Execute()
		{
			if (execDelegate != null)
			{
				execDelegate();
			}
		}

		//ステート名を取得するメソッド
		public abstract string getStateName();
	}

	// 以下状態クラス

	//  DefaultPosition
	public class TextStateDefault : TextState
	{
		public override string getStateName()
		{
			return "State:Default";
		}
	}

	//  StateA
	public class TextStateA : TextState
	{
		public override string getStateName()
		{
			return "State:A";
		}
	}

	//  StateB
	public class TextStateB : TextState
	{
		public override string getStateName()
		{
			return "State:B";
		}

		public override void Execute()
		{
			Debug.Log("特別な処理がある場合は子が処理してもよい");
			if (execDelegate != null)
			{
				execDelegate();
			}
		}
	}
}