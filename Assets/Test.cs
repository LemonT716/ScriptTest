using System.Collections;
using UnityEngine;

public class Boss{
	
	private int hp = 100;  //体力
	private int power = 25;  //攻撃力
	private int mp=53;


	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;  //残りhpを減らす
	}

	public void Magic(){
		mp -= 5;
		if (mp >= 0) {
				Debug.Log ("魔法攻撃をした。残りMPは" + mp);
			} else {
			Debug.Log ("MPが足りないため魔法が使えない");
		} 
			
	}
}

public class Test : MonoBehaviour{

	void Start () {

		int[] array = { 10, 11, 12, 13, 14 };
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}
		for (int j = 4; j >= 0; j--) {
			Debug.Log (array [j]);
		}


		Boss lastboss = new Boss ();
		lastboss.Attack ();
		lastboss.Defence (3);
		for (int k = 0; k < 11; k++) {
			lastboss.Magic ();
		}
	}

	void Update () {
		
	}
}