using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	[SerializeField]
	GameObject enemy;
	float currentTime;
	[SerializeField]
	float timeBetweenSpawns=5;
	// Use this for initialization
	void Start () {
		Spawn();
		currentTime=timeBetweenSpawns;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime-=Time.deltaTime;
		if(currentTime<=0){
			Spawn();
		}

	}
	void Spawn(){
			Debug.Log("Spawn");
			currentTime=timeBetweenSpawns;
			Instantiate(enemy,transform.position,Quaternion.identity);

	}
	private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 0.5f);
	}
}
