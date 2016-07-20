//Audioで苦戦したときのテスト用スクリプト

using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	public AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other) {
		audioSource.Play(); 
		Debug.Log("hit");
	}
}
