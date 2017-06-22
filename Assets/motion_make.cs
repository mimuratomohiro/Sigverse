using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion_make : MonoBehaviour {
    public GameObject Ref;
    public GameObject Hips;
    public GameObject LeftUpLeg;
    public GameObject LeftLeg;
    public GameObject RightUpLeg;
    public GameObject RightLeg;
    public GameObject Spine1;
    public GameObject Spine2;
    public GameObject LeftShoulder;
    public GameObject LeftArm;
    public GameObject LeftForeArm;
    public GameObject LeftHand;
    public GameObject RightShoulder;
    public GameObject RightArm;
    public GameObject RightForeArm;
    public GameObject RightHand;
    public GameObject Neck;
    public GameObject Head;

    public Rigidbody Hips_r,LeftUpLeg_r,LeftLeg_r,RightUpLeg_r, RightLeg_r;
    public Rigidbody Spine2_r;
    public Rigidbody LeftShoulder_r,LeftArm_r,LeftForeArmv,LeftHand_r;
    public Rigidbody RightShoulder_r,RightArm_r,RightForeArm_r,RightHand_r;
    public Rigidbody Head_r;

    float t = 0;

    void Start()
    {
        Ref = this.transform.FindChild("Character1_Reference").gameObject;
        Hips = Ref.gameObject.transform.FindChild("Character1_Hips").gameObject;
        LeftUpLeg = Hips.transform.FindChild("Character1_LeftUpLeg").gameObject;
        LeftLeg = LeftUpLeg.transform.FindChild("Character1_LeftLeg").gameObject;
        RightUpLeg = Hips.transform.FindChild("Character1_RightUpLeg").gameObject;
        RightLeg = RightUpLeg.transform.FindChild("Character1_RightLeg").gameObject;
        Spine1 = Hips.transform.FindChild("Character1_Spine").gameObject.transform.FindChild("Character1_Spine1").gameObject;
        Spine2 = Spine1.transform.FindChild("Character1_Spine2").gameObject;
        LeftShoulder = Spine2.transform.FindChild("Character1_LeftShoulder").gameObject;
        LeftArm = LeftShoulder.transform.FindChild("Character1_LeftArm").gameObject;
        LeftForeArm = LeftArm.transform.FindChild("Character1_LeftForeArm").gameObject;
        LeftHand = LeftForeArm.transform.FindChild("Character1_LeftHand").gameObject;
        RightShoulder = Spine2.transform.FindChild("Character1_RightShoulder").gameObject;
        RightArm = RightShoulder.transform.FindChild("Character1_RightArm").gameObject;
        RightForeArm = RightArm.transform.FindChild("Character1_RightForeArm").gameObject;
        RightHand = RightForeArm.transform.FindChild("Character1_RightHand").gameObject;
        Neck = Spine2.transform.FindChild("Character1_Neck").gameObject;
        Head = Neck.transform.FindChild("Character1_Head").gameObject;


        Hips_r = Hips.GetComponent<Rigidbody>();
        LeftUpLeg_r = LeftUpLeg.GetComponent<Rigidbody>();
        LeftLeg_r = LeftLeg.GetComponent<Rigidbody>();
        RightUpLeg_r = RightUpLeg.GetComponent<Rigidbody>();
        RightLeg_r = RightLeg.GetComponent<Rigidbody>();
        Spine2_r = Spine2.GetComponent<Rigidbody>(); 
        LeftShoulder_r = LeftForeArm.GetComponent<Rigidbody>();
        LeftArm_r = LeftArm.GetComponent<Rigidbody>();
        RightShoulder_r = RightForeArm.GetComponent<Rigidbody>();
        RightArm_r = RightArm.GetComponent<Rigidbody>();
        Head_r = Head.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        t += 1;
    }
    void FixedUpdate()
    {
        if (t % 100 == 0)
        {
            Hips_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-1.0f, 1.0f));
            LeftUpLeg_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-1.0f, 1.0f));
            LeftLeg_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-1.0f, 1.0f));
            RightUpLeg_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-1.0f, 1.0f));
            RightLeg_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-1.0f, 1.0f));
            Spine2_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-1.0f, 1.0f));
            LeftShoulder_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-5.0f, 5.0f));
            LeftArm_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-1.0f, 1.0f));
            RightShoulder_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-5.0f, 5.0f));
            RightArm_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-1.0f, 1.0f));
            Head_r.AddTorque(new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)) * Random.Range(-1.0f, 1.0f));
        }
    }
}

