using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformModifier : MonoBehaviour {

    public Transform target;
    public Vector3 translation;
    public Vector3 rotation;
    public Vector3 scale;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	public void Update () {

        target.transform.Translate(translation * Time.deltaTime);
        target.transform.Translate(rotation * Time.deltaTime);
        target.transform.Translate(scale * Time.deltaTime);
    }
}
