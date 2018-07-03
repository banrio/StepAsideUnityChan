using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemdestroy : MonoBehaviour {

	//Prefabにつける。

	//unityちゃんのオブジェクト
	private GameObject unitychan;

	//carPrefabを入れる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//cornPorefabをいれる
	public GameObject conePrefab;
	//unityちゃんとcarの距離
	public float distancecar;
	//unityちゃんとcoinの距離
	public float distancecoin;
	//unityちゃんとcornの距離
	public float distancecorn;


	// Use this for initialization
	void Start () {


		//unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");

		//unityちゃんとオブジェクトの差を求める。
		//this.distancecar = unitychan.transform.position.z - car.transform.position.z;
		//this.distancecoin = unitychan.transform.position.z - coin.transform.position.z;
		//this.distancecorn = unitychan.transform.position.z - corn.transform.position.z;

		//Start()にあるので一度しか呼ばれない距離。時間に対して不変値となってしまう。
		
	}
	
	// Update is called once per frame
	void Update () {

		//アイテム位置がunityちゃんの後方10mになったら、破棄する。 

		if (unitychan.transform.position.z - this.gameObject.transform.position.z > 10f) {
			Destroy(this.gameObject);
		}


		//下：間違え

		//if (this.distancecoin < -15f) {
		//	GameObject coin = Instantiate (conePrefab) as GameObject;
		//	GameObject.Destroy (coin);
		//}
		//
		//if (this.distancecorn < -15f) {
		//	GameObject corn = Instantiate (coinPrefab) as GameObject;
		//	GameObject.Destroy (corn) ;
		//}
				


		
	}
}
