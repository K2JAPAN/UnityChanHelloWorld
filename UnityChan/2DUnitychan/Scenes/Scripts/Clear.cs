using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {

public GameObject ClearText;

void Start () {		}
  void Update () {

  }

	// トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter2D (Collider2D other){
    //  if (col.gameObject.tag == "Player")
    if (other.tag == "Player") {
  //  gameObject.GetComponent<PlayerScript>().enabled = false;
	}
		// 接触対象はPlayerタグですか？
		if (other.tag == "Player") {
  //  if (col.gameObject.tag == "Player"){
    StartCoroutine("GameOver");
}}
			// このコンポーネントを持つGameObjectを破棄する
      IEnumerator GameOver () {
      yield return new WaitForSeconds(2.0f);
      int sceneIndex = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(sceneIndex-1);
  		}
    }
