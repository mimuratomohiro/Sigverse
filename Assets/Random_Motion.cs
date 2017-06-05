using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Random_Motion : MonoBehaviour {
	public GameObject mmdPlayerObject;

	MMD4MecanimBone  HipsBone;
	MMD4MecanimBone  LeftUpLegBone;
	MMD4MecanimBone  LeftLegBone;
	MMD4MecanimBone  RightUpLegBone;
	MMD4MecanimBone  RightLegBone;
	MMD4MecanimBone  LeftShoulderBone;
	MMD4MecanimBone  LeftArmBone;
	MMD4MecanimBone  RightShoulderBone;
	MMD4MecanimBone  RightArmBone;
	MMD4MecanimBone  NeckBone;
	MMD4MecanimBone  WaistBone;

	Vector3 HipsVec;    
	Vector3 LeftUpLegVec;        
	Vector3 LeftLegVec;        
	Vector3 RightUpLegVec;      
	Vector3 RightLegVec;       
	Vector3 LeftShoulderVec;  
	Vector3 LeftArmVec;      
	Vector3 RightShoulderVec;
	Vector3 RightArmVec;     
	Vector3 NeckVec;   
	Vector3 WaistVec;  
	int t = 0;

	// Use this for initialization
	public GameObject Ref;
	public GameObject Hips;
	public GameObject LeftUpLeg;
	public GameObject LeftLeg;
	public GameObject RightUpLeg;
	public GameObject RightLeg;
	public GameObject LeftShoulder;
	public GameObject LeftArm;
	public GameObject LeftForeArm;
	public GameObject LeftHand;
	public GameObject RightShoulder;
	public GameObject RightArm;
	public GameObject RightForeArm;
	public GameObject RightHand;
	public GameObject Neck;
	public GameObject Waist;


	void Start () {
		Ref             = this.transform.FindChild("158.!Root").gameObject;
		Hips            = Ref.gameObject.transform.FindChild( "8.joint_HipMaster" ).gameObject;
		LeftUpLeg       = Hips.gameObject.transform.FindChild( "12.joint_LeftHip" ).gameObject;
		LeftLeg         = LeftUpLeg.gameObject.transform.FindChild( "13.joint_LeftKnee" ).gameObject;
		RightUpLeg      = Hips.gameObject.transform.FindChild( "9.joint_RightHip" ).gameObject;
		RightLeg        = RightUpLeg.gameObject.transform.FindChild( "10.joint_RightKnee" ).gameObject;
		LeftShoulder    = Hips.gameObject.transform.FindChild( "15.joint_Torso" ).FindChild( "16.joint_Torso2" ).FindChild( "59.joint_LeftShoulder" ).gameObject;
		LeftArm         = LeftShoulder.gameObject.transform.FindChild( "60.joint_LeftArm" ).FindChild( "62.joint_LeftElbow" ).gameObject;
		RightShoulder   = Hips.gameObject.transform.FindChild( "15.joint_Torso" ).FindChild( "16.joint_Torso2" ).FindChild( "38.joint_RightShoulder" ).gameObject;
		RightArm        = RightShoulder.gameObject.transform.FindChild( "39.joint_RightArm" ).FindChild( "41.joint_RightElbow" ).gameObject;
		Neck            = Hips.gameObject.transform.FindChild( "15.joint_Torso" ).FindChild( "16.joint_Torso2" ).FindChild( "17.joint_Neck" ).gameObject;
		Waist           = Ref.gameObject.transform.FindChild( "0.!joint_Master" ).FindChild( "1.!joint_Center" ).FindChild( "2.!joint_guru^bu" ).FindChild( "3.!joint_Waist" ).gameObject;


		HipsBone         = Hips.GetComponent<MMD4MecanimBone>();
		LeftUpLegBone    = LeftUpLeg.GetComponent<MMD4MecanimBone>();
		LeftLegBone      = LeftLeg.GetComponent<MMD4MecanimBone>();
		RightUpLegBone   = RightUpLeg.GetComponent<MMD4MecanimBone>();
		RightLegBone     = RightLeg.GetComponent<MMD4MecanimBone>();
		LeftShoulderBone = LeftShoulder.GetComponent<MMD4MecanimBone>();
		LeftArmBone      = LeftArm.GetComponent<MMD4MecanimBone>();
		RightShoulderBone= RightShoulder.GetComponent<MMD4MecanimBone>();
		RightArmBone     = RightArm.GetComponent<MMD4MecanimBone>();
		NeckBone         = Neck.GetComponent<MMD4MecanimBone>();
		WaistBone        = Waist.GetComponent<MMD4MecanimBone>();

		HipsVec         = new Vector3(1, 0, 0);       
		LeftUpLegVec    = new Vector3(0, 1, 0);      
		LeftLegVec      = new Vector3(0, 0, 1);     
		RightUpLegVec   = new Vector3(1, 1, 0);     
		RightLegVec     = new Vector3(1, 0, 1);     
		LeftShoulderVec = new Vector3(0, 1, 1);   
		LeftArmVec      = new Vector3(1, 1, 1);   
		RightShoulderVec= new Vector3(1, 1, 1);   
		RightArmVec     = new Vector3(1, 1, 1);   
		NeckVec         = new Vector3(1, 1, 1);   
		WaistVec        = new Vector3(1, 1, 1);   

	}
	
	// Update is called once per frame
	void Update () {
		t = t + 1;
		//HipsBone.userRotation = Quaternion.Slerp(Hips.transform.rotation , Hips.transform.rotation,1);
		HipsBone.userEulerAngles          = HipsVec         * t*1;
		//LeftUpLegBone.userEulerAngles     = LeftUpLegVec    * t*1;
		//LeftLegBone.userEulerAngles       = LeftLegVec      * t*1;
		//RightUpLegBone.userEulerAngles    = RightUpLegVec   * t*1;
		//RightLegBone.userEulerAngles      = RightLegVec     * t*1;
		//LeftShoulderBone.userEulerAngles  = LeftShoulderVec * t*1;
		//LeftArmBone.userEulerAngles       = LeftArmVec      * t*1;
		//RightShoulderBone.userEulerAngles = RightShoulderVec* t*1;
		//RightArmBone.userEulerAngles      = RightArmVec     * t*1;
		//NeckBone.userEulerAngles          = NeckVec         * t*1;
		//WaistBone.userEulerAngles         = WaistVec        * t*1;

    }
}
