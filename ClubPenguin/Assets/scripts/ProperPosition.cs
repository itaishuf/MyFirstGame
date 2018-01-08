using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProperPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.Translate(Vector3.up * 0.5f, Space.Self);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
