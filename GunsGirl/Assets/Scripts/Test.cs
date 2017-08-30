using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    TransformHelper.FindChild(GameObject.Find("0").transform, "3");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
