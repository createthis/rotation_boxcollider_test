﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoStuff : MonoBehaviour {

    private void Report() {
        Quaternion oldRotation = transform.rotation;
        transform.rotation = Quaternion.identity;
        BoxCollider boxCollider = GetComponent<BoxCollider>();
        Vector3 size = boxCollider.size;
        Vector3 worldSize = transform.TransformVector(size);
        Debug.Log("size.x=" + size.x + ",worldSize.x="+worldSize.x);
        transform.rotation = oldRotation;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Report();
	}
}
