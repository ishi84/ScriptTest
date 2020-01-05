using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	int mp = 53;
	public void Magic(){
		if (mp >= 5) {
			mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = new int[5]{1,2,3,4,5};
		//配列を順番に表示
		for (var i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}
		//配列を逆順に表示
		for (var i = array.Length-1; i>=0; i--) {
			Debug.Log (array [i]);
		}
		//発展課題
		Boss boss =  new Boss();
		for (var i = 0; i < 11; i++) {
			boss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
