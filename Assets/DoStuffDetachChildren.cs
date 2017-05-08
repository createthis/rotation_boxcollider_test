using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoStuffDetachChildren : MonoBehaviour {
    public static Transform[] DetachChildren(GameObject gameObject) {
        Transform[] children = new Transform[gameObject.transform.childCount];
        int i = 0;
        foreach (Transform T in gameObject.transform) {
            children[i++] = T;
        }
        gameObject.transform.DetachChildren();
        return children;
    }

    public static void ReattachChildren(Transform[] children, GameObject gameObject) {
        foreach (Transform T in children) {
            T.parent = gameObject.transform;
        }
    }

    private void Report() {
        Quaternion oldRotation = transform.rotation;
        Transform oldParent = transform.parent;
        Transform[] children = DetachChildren(oldParent.gameObject);
        transform.rotation = Quaternion.identity;
        //transform.rotation = transform.rotation * Quaternion.Inverse(SumAncestorRotations());
        BoxCollider boxCollider = GetComponent<BoxCollider>();
        Vector3 size = boxCollider.size;
        Vector3 worldSize = transform.TransformVector(size);
        Debug.Log("size.x=" + size.x + ",worldSize.x="+worldSize.x);
        transform.rotation = oldRotation;
        ReattachChildren(children, oldParent.gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Report();
	}
}
