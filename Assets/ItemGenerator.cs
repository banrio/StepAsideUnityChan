using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	//車・カラーコーン・コインをゲーム中に生成するスクリプト

	//carPrefabを入れる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//cornPorefabをいれる
	public GameObject conePrefab;
	//スタート地点（アイテムを生成する地点）
	public int startPos = -160;
	//ゴール地点
	public int goalPos = 120;
	//アイテムを出すx方向の範囲
	private float posRange = 3.4f;
	//unityちゃんのオブジェクト
	private GameObject unitychan;

	//アイテムを出す地点
	private int targetPos = -145;


	// Use this for initialization
	void Start () {
		
	}
		
	
	// Update is called once per frame
	void Update ()
	{
		//unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");

		//スタートから15m先からアイテムを45m先に出す。ゴール手前50mからアイテムを出すのをやめる。
		//修正する：-160からアイテムが出るように。
		if (this.unitychan.transform.position.z > targetPos && this.unitychan.transform.position.z < (goalPos - 50f)) {
				//45m先にアイテムを出す
				int num = Random.Range (0, 50);

				if (num <= 1) {
					//アイテムを置くZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range (45, 50);
					//コーンをx軸方向に一直線に生成
					for (float j = -1; j <= 1; j += 0.4f) {
						GameObject cone = Instantiate (conePrefab) as GameObject;
						cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, this.unitychan.transform.position.z + offsetZ);
					}

				} else {
					//レーンごとにアイテムを生成
					for (int j = -1; j < 2; j++) {
						//アイテムの種類を決める
						int item = Random.Range (1, 11);
						//アイテムを置くZ座標のオフセットをランダムに設定
						int offsetZ = Random.Range (45, 50);
						//60%コイン配置：30%車配置：10%何もなし
						if (1 <= item && item <= 6) {
							//コインを生成
							GameObject coin = Instantiate (coinPrefab) as GameObject;
							coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, this.unitychan.transform.position.z + offsetZ);
						} else if (7 <= item && item <= 9) {
							//車を生成
							GameObject car = Instantiate (carPrefab) as GameObject;
							car.transform.position = new Vector3 (posRange * j, car.transform.position.y, this.unitychan.transform.position.z + offsetZ);
						}
					}
				}
				//targetPosを次の地点にする
				targetPos += 15;
			} 
			
				
		} 

	}