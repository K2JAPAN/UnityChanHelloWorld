using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

	public float speed = 4f;
//********** 開始 **********//
	public float jumpPower = 700; //ジャンプ力
	public Vector2 backwardForce = new Vector2(-4.5f, 5.4f);
	public LayerMask groundLayer; //Linecastで判定するLayer
  public GameObject GameOverText;
			public GameObject Coin;
						public GameObject UnityChan;
//********** 音開始 **********//
	public AudioClip univ0010;//そんなあぁ;
public AudioClip Jump1;//やっ！;
public AudioClip Jump2;//それっ！;
	//public GameObject mainCamera;
	//********** 終了 **********//
	private Rigidbody2D rigidbody2D;
	private Animator anim;
//********** 開始 **********//
	private bool isGrounded; //着地判定
	private bool isDown = false; //
//********** 終了 **********//
private bool gameClear = false;

	void Start () {
		anim = GetComponent<Animator>();
		rigidbody2D = GetComponent<Rigidbody2D>();
	}
//********** 開始 **********//
	void Update ()
	{
		//Linecastでユニティちゃんの足元に地面があるか判定
		isGrounded = Physics2D.Linecast (
		transform.position,// + transform.up * -1,　　　//始点の値
		transform.position - transform.up * 0.3f,//終点の値
		groundLayer);
		//スペースキーを押し、
		if (Input.GetKeyDown ("space")) {
			//着地していた時、
			if (isGrounded) {
				//Dashアニメーションを止めて、Jumpアニメーションを実行
				SoundManager.instance.RandomizeSfx(Jump1,Jump2);
				anim.SetBool("Dash", false);
				anim.SetTrigger("Jump");
				//着地判定をfalse
				isGrounded = false;
			 // デバックログ表示 Debug.Log("isGrounded) ->" + isGrounded);
				//AddForceにて上方向へ力を加える
				rigidbody2D.AddForce (Vector2.up * jumpPower);
			}
		}
		//上下への移動速度を取得
		float velY = rigidbody2D.velocity.y;
		//移動速度が0.1より大きければ上昇
		bool isJumping = velY > 0.1f ? true:false;
		//移動速度が-0.1より小さければ下降
		bool isFalling = velY < -0.1f ? true:false;
		//結果をアニメータービューの変数へ反映する
		anim.SetBool("isJumping",isJumping);
		anim.SetBool("isFalling",isFalling);
								}

//穴に落ちた時のゲームオーバー処理
/*
IEnumerator GameOver  ()
{
if (transform.position.y < -10)
		  GameOverText.SetActive(true);
			yield return new WaitForSeconds(2.0f);
	int sceneIndex = SceneManager.GetActiveScene().buildIndex;
	SceneManager.LoadScene(sceneIndex-1);

}
*\
//********** 終了 **********/

	void FixedUpdate ()
	{
		float x = Input.GetAxisRaw ("Horizontal");
		if (x != 0) {
			rigidbody2D.velocity = new Vector2 (x * speed, rigidbody2D.velocity.y);
			Vector2 temp = transform.localScale;
			temp.x = x;
			transform.localScale = temp;
			anim.SetBool ("Dash", true);

			//********** 開始 **********//
	/*			//画面中央から左に4移動した位置をユニティちゃんが超えたら
						if (transform.position.x > mainCamera.transform.position.x - 4) {
							//カメラの位置を取得
							Vector3 cameraPos = mainCamera.transform.position;
							//ユニティちゃんの位置から右に4移動した位置を画面中央にする
							cameraPos.x = transform.position.x + 4;
							mainCamera.transform.position = cameraPos;
						}
						//カメラ表示領域の左下をワールド座標に変換
						Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
						//カメラ表示領域の右上をワールド座標に変換
						Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
						//ユニティちゃんのポジションを取得
						Vector2 pos = transform.position;
						//ユニティちゃんのx座標の移動範囲をClampメソッドで制限
						pos.x = Mathf.Clamp(pos.x, min.x + 0.5f, max.x);
						transform.position = pos;
			//********** 終了 **********/
					} else {
						rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
						anim.SetBool ("Dash", false);

					}
					// 敵と接触してしまうと、ゲームオーバーになるスクリプトトリガーとの接触時に呼ばれるコールバック
										}
									//	void OnTriggerStay2D(Collider2D other)	{
									//		if (other.tag == "Enemy")
										//	StartCoroutine("GameOver");
                  //  {
									//		GameOverText.SetActive(true);
									//		Destroy(Coin.gameObject);
									//		yield return new WaitForSeconds(2.0f);
									//			int sceneIndex = SceneManager.GetActiveScene().buildIndex;
									//			SceneManager.LoadScene(sceneIndex-1);
										//	}
											//}
											//	void OnTriggerStay2D(Collider2D other)	  {
											//こっからダウンとシーンチェンジ
													void OnCollisionEnter2D (Collision2D col){
		                       	if (col.gameObject.tag == "Enemy")	{

										           // m_state = State.Damaged;
										            //StartCoroutine(INTERNAL_OnDamage());
																anim.SetBool("Dash", false);
										  					anim.SetBool("Jump", false);
											//					anim.SetTrigger("Down");
																anim.SetBool("isDown",isDown);

																SoundManager.instance.RandomizeSfx(univ0010);//そんなあぁ;
																//ああ if (col.gameObject.tag == "Enemy")
																//	StartCoroutine("GameOver");
																	//yield return new WaitForSeconds(.2f);

                              //a    }
																//a	if (col.gameObject.tag == "Enemy")	{
														//a			StartCoroutine("GameOver");
//a }}
		//a															IEnumerator GameOver (){
				//a													GameOverText.SetActive(true);
						//a											Destroy(Coin.gameObject);
								//a									 	yield return new WaitForSeconds(2.0f);
										//a								int sceneIndex = SceneManager.GetActiveScene().buildIndex;
												//a						SceneManager.LoadScene(sceneIndex-1);
														//a		}
															//		IEnumerator GameOver () {
																	//	yield return new WaitForSeconds(2.0f);
																	//	int sceneIndex = SceneManager.GetActiveScene().buildIndex;
																//		SceneManager.LoadScene(sceneIndex-1);
					       }
					       }
							 }

										       // IEnumerator Down()	  {
										        //m_animator.Play(m_isGround ? "Damage" : "AirDamage");
										        //m_animator.Play("Idle");
												//				{
												  		//anim.SetBool("isDown",isDown);
												//		}
										       // SendMessage("OnDamage", SendMessageOptions.DontRequireReceiver);

										      //  rigidbody2D.velocity = new Vector2(transform.right.x * backwardForce.x, transform.up.y * backwardForce.y);
			                    //ああ if (col.gameObject.tag == "Enemy")
													//ああ 	StartCoroutine("GameOver");
										        //yield return new WaitForSeconds(.2f);
												//	}
													//	IEnumerator GameOver () {
													//		GameOverText.SetActive(true);
													//		Destroy(Coin.gameObject);
													//		yield return new WaitForSeconds(2.0f);
													//		int sceneIndex = SceneManager.GetActiveScene().buildIndex;
													//		SceneManager.LoadScene(sceneIndex-1);

										         //   yield return new WaitForFixedUpdate();

										        //m_animator.SetTrigger("Invincible Mode");
										        //m_state = State.Invincible;
										  //  }
