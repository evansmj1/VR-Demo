using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightAdjust : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.H))
        {
            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y - (float).01;
            float z = gameObject.transform.position.z;
            gameObject.transform.SetPositionAndRotation(new Vector3(x, y, z), new Quaternion());
        }
        if (Input.GetKey(KeyCode.J))
        {
            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y + (float).01;
            float z = gameObject.transform.position.z;
            gameObject.transform.SetPositionAndRotation(new Vector3(x, y, z), new Quaternion());
        }
    }
}
