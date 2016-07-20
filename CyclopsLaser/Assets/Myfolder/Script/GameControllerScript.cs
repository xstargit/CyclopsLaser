//Cubeの生成
//スコアの保持　ScoreTextにスコアを送って表示する
//点の加算はObjectDestroyスクリプトで行う

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour {

	public Text ScoreText;	//uGUIを格納
	public int score;		//スコアを格納
	public float j;			//オブジェクト生成を回す時に使う
	public GameObject ImageTarget;	//ImageTargetの子として生成したいので取得
	public GameObject[] CubePrefab;			//CubePrefab
	public bool isPlaying = true;

	GameObject SampleCubes(){
		GameObject prefab = null;
		
		int index = Random.Range (0, CubePrefab.Length);
		prefab = CubePrefab [index];
		
		return prefab;
	}

	void Start () {
		//オブジェクトの座標

	}

	void Update () {
		ScoreText.text = "Score : " + score;	//uGUIを使ったスコア表示
		float x = Random.Range(-1520.0f, 2000.0f);
		float y = Random.Range(-750.0f, 1750.0f);
		float z = Random.Range(2500.0f, 3750.0f);
		j++;
		if(j%30 == 1 && isPlaying){
			GameObject Cubes = (GameObject)Instantiate (
				SampleCubes(),
				new Vector3 (x,y,z),
				Quaternion.identity
			);
			//Destroy(Cubes,5);
			Cubes.transform.parent = ImageTarget.transform;
		}
	}
}
