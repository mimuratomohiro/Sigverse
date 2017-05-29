using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    GameObject base_footprint_obj;
    // Use this for initialization
    void Start () {
        base_footprint_obj = this.transform.FindChild("0.!joint_Master").gameObject;
        print(base_footprint_obj);
    }
	
	// Update is called once per frame
	void Update () {

        //this.transform.rotation.SetAxisAngle();
        //this.transform.FindChild().gameObject;
        this.transform.Rotate(new Vector3(5, 5, 5));
    }
}
