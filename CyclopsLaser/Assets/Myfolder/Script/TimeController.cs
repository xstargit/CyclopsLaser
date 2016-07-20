//制限時間とタイトルへ遷移

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeController : MonoBehaviour {

	public float time = 30;
	public GameObject GameOverText;
	public GameObject GameController;
	public GameControllerScript gamecontrollerscript;
	public AudioSource splatoon;

	void Start () {
		splatoon = GetComponent<AudioSource> ();
		splatoon.Play();
		GameOverText.SetActive(false);
		GameController = GameObject.Find ("GameController");							//GameCotrollerScriptを使うためそれがアタッチされたGameControllerオブジェクトを取得
		gamecontrollerscript = GameController.GetComponent<GameControllerScript>();
	}
	
	void Update (){
		time -= Time.deltaTime;		//1秒に1ずつ減らしていく
		GetComponent<Text> ().text = ((int)time).ToString ();

		if (time < 0) {
			time = 0;
			StartCoroutine("GameOver");
			gamecontrollerscript.isPlaying = false;
		}
	}

	IEnumerator GameOver () {
		GameOverText.SetActive(true);
		yield return new WaitForSeconds(2.0f);
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel ("title");
		}
	}



}