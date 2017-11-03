using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ItemScript : MonoBehaviour {

public GameObject ClearText;
private static GameObject coin;
private static GameObject UnityChan;
public AudioClip GetCoin;
public AudioClip Coin;

void Start () {

 coin = GameObject.Find("coin");}
  void Update () {

  }

	// トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter2D (Collider2D other){
    //  if (col.gameObject.tag == "Player")
    if (other.tag == "Player") {
      SoundManager.instance.RandomizeSfx(GetCoin);
	}
		// 接触対象はPlayerタグですか？
		//if (other.tag == "Player") {
  //  if (col.gameObject.tag == "Player"){
    //StartCoroutine("GameOver");
}}
			// このコンポーネントを持つGameObjectを破棄する
      //IEnumerator GameOver () {
    //  ClearText.SetActive(true);
    //  yield return new WaitForSeconds(1.0f);
      //coin.SetActive(false);
    //  int sceneIndex = SceneManager.GetActiveScene().buildIndex;
      //SceneManager.LoadScene(sceneIndex+1);
  		//}
    //}
