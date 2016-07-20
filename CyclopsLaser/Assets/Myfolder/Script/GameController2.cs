using UnityEngine;
using System.Collections;

public class GameController2 : MonoBehaviour {
	public int j;
	public bool isPlaying = true;

	public GameObject[] CubePrefab;			//CubePrefab
	public GameObject ImageTarget;	//ImageTargetの子として生成したいので取得

	void Start () {
	
	}

	GameObject MoriShinichi(){
		GameObject prefab = null;
		
		int index = Random.Range (0, CubePrefab.Length);
		prefab = CubePrefab [index];
		
		return prefab;
	}//CubePrefab

	
	void Update () {
		float x = Random.Range(-1520.0f, 2000.0f);
		float y = Random.Range(-750.0f, 1750.0f);
		float z = Random.Range(2500.0f, 3750.0f);
		if (j % 1000 == 1 && isPlaying) {
			GameObject Block = (GameObject)Instantiate (
				MoriShinichi (),
				new Vector3 (x, y, z),
				transform.rotation
				);
			Block.transform.parent = ImageTarget.transform;
		}
		j++;
	}
}
