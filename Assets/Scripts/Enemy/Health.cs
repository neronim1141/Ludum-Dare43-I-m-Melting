using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	[SerializeField]
	private float health=5;
	[SerializeField]
	private TextMesh text;
	// Use this for initialization
	void Start () {
		text.text=health.ToString();
	}
	
	public void damage(float d){
		health-=d;
		if(health<=0){
			Destroy(this.gameObject);
		}
		text.text=health.ToString();
	}
}
