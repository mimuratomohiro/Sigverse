using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;
using System;

public class save : MonoBehaviour
{
    public SkinnedMeshRenderer renderers1, renderers2, renderers3, renderers4;
    public GameObject name1, name2, name3, name4;
    public Mesh mesh1, mesh2, mesh3, mesh4;
    public Vector3[] vertices1, vertices2, vertices3, vertices4;
    public Vector3[] normals1, normals2, normals3, normals4;

    void Start()
    {

        renderers1 = this.transform.FindChild("U_Char").FindChild("U_Char_0").GetComponent<SkinnedMeshRenderer>();
        renderers2 = this.transform.FindChild("U_Char").FindChild("U_Char_1").GetComponent<SkinnedMeshRenderer>();
        renderers3 = this.transform.FindChild("U_Char").FindChild("U_Char_2").GetComponent<SkinnedMeshRenderer>();
        renderers4 = this.transform.FindChild("U_Char").FindChild("U_Char_3").GetComponent<SkinnedMeshRenderer>();

        name1 = this.transform.FindChild("U_Char").FindChild("U_Char_0").gameObject;
        name2 = this.transform.FindChild("U_Char").FindChild("U_Char_1").gameObject;
        name3 = this.transform.FindChild("U_Char").FindChild("U_Char_2").gameObject;
        name4 = this.transform.FindChild("U_Char").FindChild("U_Char_3").gameObject;

        mesh1 = renderers1.sharedMesh;
        mesh2 = renderers2.sharedMesh;
        mesh3 = renderers3.sharedMesh;
        mesh4 = renderers4.sharedMesh;

        vertices1 = mesh1.vertices;
        vertices2 = mesh2.vertices;
        vertices3 = mesh3.vertices;
        vertices4 = mesh4.vertices;
     

        normals1 = mesh1.normals;
        normals2 = mesh2.normals;
        normals3 = mesh3.normals;
        normals4 = mesh4.normals;
        var thisMatrix = transform.localToWorldMatrix;


        //for (int i = 0; i < vertices.Length; i++)
        //{
        //    vectors.Add((GameObject)Instantiate(vector, this.transform.position + vertices[i], Quaternion.identity));
        //    vectors[i].transform.LookAt(normals[i]);
        //    vectors[i].transform.rotation *= Quaternion.Euler(90, 0, 90);
        //    vectors[i].transform.parent = this.transform;
        //}
        foreach (Vector3 vertex in vertices1)
        {
            Vector3 vec1 = thisMatrix.MultiplyPoint3x4(vertex);
        }
        foreach (Vector3 vertex in vertices2)
        {
            Vector3 vec2 = thisMatrix.MultiplyPoint3x4(vertex);
        }
        foreach (Vector3 vertex in vertices3)
        {
            Vector3 vec3 = thisMatrix.MultiplyPoint3x4(vertex);
        }
        foreach (Vector3 vertex in vertices4)
        {
            Vector3 vec4 = thisMatrix.MultiplyPoint3x4(vertex);
        }
        var count = vertices1.Length + vertices2.Length + vertices3.Length + vertices4.Length;
        Debug.Log("all vertex at" + count);

    }
    void Update()
    {
        var count = vertices1.Length + vertices2.Length + vertices3.Length + vertices4.Length;
        Debug.Log("all vertex at" + count);
    }
}
