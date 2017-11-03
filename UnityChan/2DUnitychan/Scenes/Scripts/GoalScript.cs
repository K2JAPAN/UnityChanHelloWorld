using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour {

public GameObject ClearText;
public GameObject Coin;
private Animator anim;
public AudioClip GetCoin;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D (Collider2D other){
		if (other.tag  == "Player")	{
		//	    SoundManager.instance.RandomizeSfx(GetCoin);
			      //SoundManager.instance.RandomizeSfx(GetCoin);
	// gameObject.GetComponent<PlayerScript>().enabled = false;

	}

	if (other.tag  == "Player")	{
	StartCoroutine("Goal");

	}}
					IEnumerator Goal (){
				//	gameObject.GetComponent<PlayerScript>().enabled = false;
				ClearText.SetActive(true);
				Destroy(Coin.gameObject);
						yield return new WaitForSeconds(2.0f);
						int sceneIndex = SceneManager.GetActiveScene().buildIndex;
						SceneManager.LoadScene(sceneIndex+1);
	}
				}
