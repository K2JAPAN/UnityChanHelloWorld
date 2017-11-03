using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
	private float time = 99;

	//********** 追記 **********//
		public GameObject GameOverText;
		public GameObject Coin;
	//********** 追記 **********//

		void Start () {
	//********** 追記 **********//
			GameOverText.SetActive(false);
	//********** 追記 **********//
			GetComponent<Text>().text = ((int)time).ToString();
		}

		void Update ()
		{
			time -= Time.deltaTime;
	//********** 追記 **********//
			if (time < 0) {
				StartCoroutine("GameOver");
			}
	//********** 追記 **********//
			if (time < 0) time = 0;
			GetComponent<Text> ().text = ((int)time).ToString ();
		}
	//********** 追記 **********//
		IEnumerator GameOver () {
			GameOverText.SetActive(true);
			Destroy(Coin.gameObject);
			yield return new WaitForSeconds(2.0f);
			int sceneIndex = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene(sceneIndex-1);
			}
		}
	//********** 追記 **********//
