using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class RoboScript : MonoBehaviour {
    int t = 0;
    public SkinnedMeshRenderer renderers1, renderers2;
    public GameObject name1, name2;
    public Mesh mesh1, mesh2;
    public Vector3[] vertices1, vertices2;
    public Vector3[] normals1, normals2;
    public GameObject plane1;



    // Use this for initialization
    void Start () {
        List<GameObject> vectors = new List<GameObject>();


        renderers1 = this.transform.FindChild("Mesh_SD_unitychan").FindChild("_body").GetComponent<SkinnedMeshRenderer>();
        renderers2 = this.transform.FindChild("Character1_Reference").FindChild("Character1_Hips").FindChild("Character1_Spine").FindChild("Character1_Spine1").FindChild("Character1_Spine2").FindChild("Character1_Neck").FindChild("Character1_Head").FindChild("_face").GetComponent<SkinnedMeshRenderer>();
        //renderers2 = this.transform.FindChild("Mesh_SD_unitychan").FindChild("_face").GetComponent<SkinnedMeshRenderer>();


        mesh1 = renderers1.sharedMesh;
        mesh2 = renderers2.sharedMesh;

        vertices1 = mesh1.vertices;
        vertices2 = mesh2.vertices;


        normals1 = mesh1.normals;
        normals2 = mesh2.normals;

        name1 = this.transform.FindChild("Mesh_SD_unitychan").FindChild("_body").gameObject;
        name2 = this.transform.FindChild("Character1_Reference").FindChild("Character1_Hips").FindChild("Character1_Spine").FindChild("Character1_Spine1").FindChild("Character1_Spine2").FindChild("Character1_Neck").FindChild("Character1_Head").FindChild("_face").gameObject;
        //name2 = this.transform.FindChild("Mesh_SD_unitychan").FindChild("_face").gameObject;



        var thisMatrix = transform.localToWorldMatrix;
        t += 1;



        foreach (Vector3 vertex in vertices1)
        {
            Vector3 vec1 = thisMatrix.MultiplyPoint3x4(Quaternion.Euler(name1.transform.eulerAngles) * vertex) + name1.transform.position;       
        }


        foreach (Vector3 vertex in vertices2)
        {
            Vector3 vec2 = thisMatrix.MultiplyPoint3x4(Quaternion.Euler(name2.transform.eulerAngles) * vertex) + name2.transform.position;
        }
        var count = vertices1.Length + vertices2.Length;


    }

    // Update is called once per frame
    void Update () {
        var thisMatrix = transform.localToWorldMatrix;
        Mesh bakedMesh1 = new Mesh();
        renderers1.BakeMesh(bakedMesh1);
        vertices1 =  bakedMesh1.vertices;
        normals1  = bakedMesh1.normals;
        Mesh bakedMesh2 = new Mesh();
        renderers2.BakeMesh(bakedMesh2);
        vertices2 = bakedMesh2.vertices;
        normals2 = bakedMesh2.normals;
        foreach (Vector3 vertex in vertices1)
        {
            //Vector3 vec1 = thisMatrix.MultiplyPoint3x4(Quaternion.Euler(name1.transform.eulerAngles) * vertex) + name1.transform.position;
            //GameObject cube = GameObject.Instantiate(plane1);
            //cube.transform.localPosition = vec1;
            //cube.transform.localScale = Vector3.one * 0.003f;
        }

        foreach (Vector3 vertex in vertices2)
        {
            //Vector3 vec2 = thisMatrix.MultiplyPoint3x4(Quaternion.Euler(name2.transform.eulerAngles) * vertex) + name2.transform.position;
            //GameObject cube = GameObject.Instantiate(plane1);
            //cube.transform.localPosition = vec2;
            //cube.transform.localScale = Vector3.one * 0.003f;
        }
        foreach (Vector3 vertex in normals1)
        {
            //Vector3 vec1 = thisMatrix.MultiplyPoint3x4(Quaternion.Euler(name1.transform.eulerAngles) * vertex) + name1.transform.position;
            //GameObject cube = GameObject.Instantiate(plane1);
            //cube.transform.localPosition = vec1;
            //cube.transform.localScale = Vector3.one * 0.003f;
        }

        foreach (Vector3 vertex in normals2)
        {
            //Vector3 vec2 = thisMatrix.MultiplyPoint3x4(Quaternion.Euler(name2.transform.eulerAngles) * vertex) + name2.transform.position;
            //GameObject cube = GameObject.Instantiate(plane1);
            //cube.transform.localPosition = vec2;
            //cube.transform.localScale = Vector3.one * 0.003f;
        }
    }
}
