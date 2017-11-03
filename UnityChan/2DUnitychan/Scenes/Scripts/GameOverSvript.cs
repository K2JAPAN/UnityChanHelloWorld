using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSvript : MonoBehaviour {

	public GameObject GameOverText;
	public GameObject Coin;
  private Animator anim;
	private bool isDown = false; //

	void Start () {		}
		void Update () {

		}

void OnCollisionEnter2D (Collision2D col){
	if (col.gameObject.tag == "Enemy")	{

		 // m_state = State.Damaged;
			//StartCoroutine(INTERNAL_OnDamage());
			gameObject.GetComponent<PlayerScript>().enabled = false;
			//anim.SetBool("Wait", false);
			//anim.SetBool("Dash", false);
			//anim.SetTrigger("Down");
			//anim.SetBool("isDown",isDown);
			//GetComponent(PlayerScript).enabled = false;
			//ああ if (col.gameObject.tag == "Enemy")
			//	StartCoroutine("GameOver");
				//yield return new WaitForSeconds(.2f);

				}
				if (col.gameObject.tag == "Enemy")	{
				StartCoroutine("GameOver");
				//anim.SetBool("Wait", false);
				//anim.SetBool("Dash", false);
				//anim.SetTrigger("Down");
				//anim.SetBool("isDown",isDown);

}}
				IEnumerator GameOver (){

			//	gameObject.GetComponent<PlayerScript>().enabled = false;
			GameOverText.SetActive(true);
			Destroy(Coin.gameObject);
					yield return new WaitForSeconds(2.0f);
					int sceneIndex = SceneManager.GetActiveScene().buildIndex;
					SceneManager.LoadScene(sceneIndex-1);

			}
		//		IEnumerator GameOver () {
				//	yield return new WaitForSeconds(2.0f);
				//	int sceneIndex = SceneManager.GetActiveScene().buildIndex;
			//		SceneManager.LoadScene(sceneIndex-1);
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
