using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CallStageScript : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(3);
		int sceneIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(sceneIndex+1);
		}
	}
