using UnityEngine;
using System.Collections;

public class Call01Script : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(3);
		Application.LoadLevel("1-1");
	}
}
