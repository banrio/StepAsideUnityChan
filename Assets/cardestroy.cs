using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardestroy : MonoBehaviour {

	//unityちゃんのオブジェクト
	private GameObject unitychan;

	//carPrefabを入れる
	public GameObject carPrefab;

	//unityちゃんとcarの距離
	public float distancecar;



	// Use this for initialization
	void Start () {
		//もととなるGameObjectから切り離す。
		GameObject car = Instantiate (carPrefab) as GameObject;


		//unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");
		//unityちゃんとオブジェクトの差を求める。
		this.distancecar = unitychan.transform.position.z - car.transform.position.z;


	}

	// Update is called once per frame
	void Update () {
		//アイテム位置がunityちゃんの後方15mになったら、破棄する。 

		if (this.distancecar < -15f) {
			GameObject car = Instantiate (carPrefab) as GameObject;
			Destroy(car);
		}
	}
}
