//ビームとキューブがぶつかったらキューブを破壊して爆発エフェクトを生成して爆発音を鳴らす
//GameControllerScriptからscoreを取ってきてキューブを破壊したとき点を加算する


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectDestroy : MonoBehaviour {

	public GameObject GameController;	
	public GameControllerScript gamecontrollerscript;
	public GameObject Explosion; //爆発エフェクトプレファブ
	public GameObject Audio; //爆発効果音が入ってるオブジェクト
	public AudioSource audioSource; //爆発効果音
	//なぜかCubeプレファブ自体に音源を仕込むと再生されないのでAudio用オブジェクトを作ってそこから取得している謎
	
	void Start () {
		Audio = GameObject.Find("Audio");									//爆発効果音の入ったAudioオブジェクトを検索
		audioSource = Audio.GetComponent<AudioSource>();					//AudioSourceコンポーネントを取得

		GameController = GameObject.Find ("GameController");							//GameCotrollerScriptを使うためそれがアタッチされたGameControllerオブジェクトを取得
		gamecontrollerscript = GameController.GetComponent<GameControllerScript>();		//GameCotrollerオブジェクトの中からGameControllerScriptをコンポーネントとして取得
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Beam" && gamecontrollerscript.isPlaying) {
			Destroy (this.gameObject);		//自分自身を破壊
			audioSource.Play();				//爆発音を鳴らす
			gamecontrollerscript.score++;	//オブジェクトを破壊した数だけスコアを加算する
			gamecontrollerscript.j++;

			Instantiate (
				Explosion,
				new Vector3 (transform.position.x,transform.position.y, transform.position.z),
				Quaternion.identity
			);								//爆発エフェクトプレファブを生成
		}
	}
}