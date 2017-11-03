using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public AudioClip coin;

	// Use this for initialization
	//void Start () {

	//}

	// Update is called once per frame
	//void Update () {

	//}

void OnCollisionEnter2D (Collision2D col){
//  if (col.gameObject.tag == "Player")
if (col.gameObject.tag == "ZIMEN")	{
SoundManager.instance.RandomizeSfx(coin);

			}
		}
}
