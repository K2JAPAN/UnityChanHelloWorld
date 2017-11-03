using UnityEngine;
using System.Collections;

public class CallED : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(6);
		Application.LoadLevel("Title");
	}
}
