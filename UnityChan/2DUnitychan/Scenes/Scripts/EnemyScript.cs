using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	Rigidbody2D rb;
	public int moveSpeed = 2;

	void Start (){
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
//********** 開始 **********//
		//localScale.xには1か-1が入る
		rb.velocity = new Vector2(transform.localScale.x*-1 * moveSpeed,
			rb.velocity.y);
//********** 終了 **********//
	}

//********** 開始 **********//
	void OnCollisionEnter2D (Collision2D col){ //2Dの衝突判定
	//void OnTriggerEnter2D (Collision2D col){
		if (col.gameObject.tag == "Wall") {   //Wallタグのついたオブジェクトと衝突時
			//ユニティちゃんのlocalScaleを変数に格納
			Vector2 temp = gameObject.transform.localScale;
			//localScale.xに-1をかける
			temp.x *= -1;
			//結果を戻す
			gameObject.transform.localScale = temp;
		}
	}
//********** 終了 **********//
}
