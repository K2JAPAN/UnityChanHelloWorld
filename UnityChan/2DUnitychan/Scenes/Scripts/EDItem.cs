using UnityEngine;
using System.Collections;

public class EDItem : MonoBehaviour
{
	// トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter2D(Collider2D other)
	{
		// 接触対象はPlayerタグですか？
		if (other.tag == "Player")
		{
			// このコンポーネントを持つGameObjectを破棄する
			Destroy(gameObject);
      Application.LoadLevel("ED");
	}
//時間が止まる Time.timeScale = 0;
    }

}
