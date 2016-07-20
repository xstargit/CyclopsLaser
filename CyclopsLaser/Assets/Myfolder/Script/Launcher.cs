//BeamPredabを生成するスクリプト

using UnityEngine;
using System.Collections;

public class Launcher: MonoBehaviour {
	public GameObject BeamPrefab;
	public GameObject Camera;
	public GameObject Beam;
	public int dx = 10;
	public int dy;
	public int dz;

	public int default_x_max = 19;
	// Use this for initialization
	void Start () {
		
	}

	void CreateBeam(){
		if (Input.GetMouseButtonDown (1)) {
			BeamPrefab.transform.parent = Camera.transform;
			Beam = (GameObject)Instantiate (BeamPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
//					}
		}
		// Update is called once per frame
/*	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			GameObject obj = (GameObject)Resources.Load ("Prefabs/BeamPrefab");
			GameObject prefab = (GameObject)Instantiate (obj);
			prefab.transform.SetParent(Camera.transform);
			Instantiate (this.BeamPrefab);
		}
	}
*/
	}
}