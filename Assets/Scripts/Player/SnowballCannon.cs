using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballCannon : MonoBehaviour {

	[SerializeField]
	private Transform _cannonTransform;
	[SerializeField]
	private Snowball snowball;

	public float Force=100;
	private void Update() {
		if(Input.GetKeyDown(KeyCode.Space)){
			Snowball sb = Instantiate<Snowball>(snowball,_cannonTransform.position,_cannonTransform.rotation,null);
			sb.Fire(Force);
		}

	}
	
}
