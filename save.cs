using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;
using System;

public class save : MonoBehaviour
{
    public SkinnedMeshRenderer renderers;
    public Mesh mesh;
    List<GameObject> vectors = new List<GameObject>();
    public Vector3[] vertices, normals;

    void Start()
    {
        var vector = Resources.Load("Vector");
        renderers = this.GetComponent<SkinnedMeshRenderer>();
        if (renderers != null)
        {
            Console.WriteLine("Hello World!");
        }
        mesh = renderers.sharedMesh;
        vertices = mesh.vertices;
        normals = mesh.normals;
        mesh.vertices = vertices;

        for (int i = 0; i < vertices.Length; i++)
        {
            vectors.Add((GameObject)Instantiate(vector, this.transform.position + vertices[i], Quaternion.identity));
            vectors[i].transform.LookAt(normals[i]);
            vectors[i].transform.rotation *= Quaternion.Euler(90, 0, 90);
            vectors[i].transform.parent = this.transform;

        }

    }
    void Update ()
    {

    }
}
