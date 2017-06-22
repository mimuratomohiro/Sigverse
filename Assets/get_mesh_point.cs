using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class get_mesh_point : MonoBehaviour {
	int t = 0;
	public SkinnedMeshRenderer renderers1, renderers2;
	public GameObject name1, name2;
	public Mesh mesh1, mesh2;
	public Vector3[] vertices1, vertices2;
	public Vector3[] normals1, normals2;
	public List<Vector3> vec1,vec2;
	public List<Vector3> norm1,norm2;
    public Vector3[,] result_vec1, result_vec2;
    public Vector3[,] result_norm1, result_norm2;
    public GameObject plane1,plane2;
    int max_num = 10;

    void Start()
    {


        renderers1 = this.transform.FindChild("Mesh_SD_unitychan").FindChild("_body").GetComponent<SkinnedMeshRenderer>();
        renderers2 = this.transform.FindChild("Character1_Reference").FindChild("Character1_Hips").FindChild("Character1_Spine").FindChild("Character1_Spine1").FindChild("Character1_Spine2").FindChild("Character1_Neck").FindChild("Character1_Head").FindChild("_face").GetComponent<SkinnedMeshRenderer>();

        mesh1 = renderers1.sharedMesh;
        mesh2 = renderers2.sharedMesh;

        vertices1 = mesh1.vertices;
        vertices2 = mesh2.vertices;


        normals1 = mesh1.normals;
        normals2 = mesh2.normals;

        name1 = this.transform.FindChild("Mesh_SD_unitychan").FindChild("_body").gameObject;
        name2 = this.transform.FindChild("Character1_Reference").FindChild("Character1_Hips").FindChild("Character1_Spine").FindChild("Character1_Spine1").FindChild("Character1_Spine2").FindChild("Character1_Neck").FindChild("Character1_Head").FindChild("_face").gameObject;

        var thisMatrix = transform.localToWorldMatrix;
        for (int ct = 0; ct < vertices1.Length; ct++)
        {
            vec1.Add(thisMatrix.MultiplyPoint3x4(Quaternion.Euler(name1.transform.eulerAngles) * vertices1[ct]) + name1.transform.position);
            norm1.Add(thisMatrix.MultiplyPoint3x4(Quaternion.Euler(name1.transform.eulerAngles) * normals1[ct]));
        }
        for (int ct = 0; ct < vertices2.Length; ct++)
        {
            vec2.Add(thisMatrix.MultiplyPoint3x4(Quaternion.Euler(name2.transform.eulerAngles) * vertices2[ct]) + name2.transform.position);
            norm2.Add(thisMatrix.MultiplyPoint3x4(Quaternion.Euler(name2.transform.eulerAngles) * normals2[ct]));
        }
        result_vec1 = new Vector3[max_num,vec1.Count];
        result_vec2 = new Vector3[max_num,vec2.Count];
        result_norm1 = new Vector3[max_num,norm1.Count];
        result_norm2 = new Vector3[max_num,norm2.Count];
    }
        // Update is called once per frame
    void Update () {
		t += 1;
		if (t < max_num) {
			var thisMatrix = transform.localToWorldMatrix;
			Mesh bakedMesh1 = new Mesh ();
			Mesh bakedMesh2 = new Mesh ();
			renderers1.BakeMesh (bakedMesh1);
			renderers2.BakeMesh (bakedMesh2);
			vertices1 = bakedMesh1.vertices;
			vertices2 = bakedMesh2.vertices;
			normals1 = bakedMesh1.normals;
			normals2 = bakedMesh2.normals;


			for (int ct = 0; ct < vec1.Count; ct++) {
				vec1 [ct] = thisMatrix.MultiplyPoint3x4 (Quaternion.Euler (name1.transform.eulerAngles) * vertices1 [ct]) + name1.transform.position;
				norm1 [ct] = thisMatrix.MultiplyPoint3x4 (Quaternion.Euler (name1.transform.eulerAngles) * normals1 [ct]);
				result_vec1 [t - 1, ct] = vec1 [ct];
				result_norm1 [t - 1, ct] = norm1 [ct];
				//GameObject cube = GameObject.Instantiate(plane1);
				//cube.transform.localPosition = vec1;
				//cube.transform.localScale = Vector3.one * 0.003f;
				//cube.transform.localScale = Vector3.one * 0.003f;
				//if (t == 500) {
				//	if (ct % 100 == 0) {
				//		GameObject cube = GameObject.Instantiate (plane2);
				//		cube.transform.LookAt (norm1 [ct]);
				//		cube.transform.localPosition = vec1 [ct];
				//		cube.transform.rotation *= Quaternion.Euler (90, 0, 90);
				//		GameObject cube2 = GameObject.Instantiate (plane1);
				//		cube2.transform.localPosition = norm1 [ct] + vec1 [ct];
				//	}
				//}
			}

			for (int ct = 0; ct < vec2.Count; ct++) {
				vec2 [ct] = thisMatrix.MultiplyPoint3x4 (Quaternion.Euler (name2.transform.eulerAngles) * vertices2 [ct]) + name2.transform.position;
				norm2 [ct] = thisMatrix.MultiplyPoint3x4 (Quaternion.Euler (name2.transform.eulerAngles) * normals2 [ct]) + name2.transform.position;
				result_vec2 [t - 1, ct] = vec2 [ct];
				result_norm2 [t - 1, ct] = norm2 [ct];
			}
		} 
		else if (t == max_num) {
			//textSave (result_vec1, result_vec2, vec1.Count, vec2.Count, "/FileName.csv");
			StreamWriter sw;
			FileInfo fi;
			fi = new FileInfo(Application.dataPath + "/FileName.csv");

			sw = fi.AppendText ();

			for (int i = 0;i<max_num; i++) {
				for (int j = 0;j<vec1.Count;j++) {
					sw.WriteLine(result_vec1[i,j].x+","+result_vec1[i,j].y+","+result_vec1[i,j].z+",");
					Debug.Log(result_vec1[i,j].x+","+result_vec1[i,j].y+","+result_vec1[i,j].z+",");
				}
				for (int j = 0;j<vec2.Count;j++) {
					sw.WriteLine(result_vec2[i,j].x+","+result_vec2[i,j].y+","+result_vec2[i,j].z+",");
					Debug.Log(result_vec2[i,j].x+","+result_vec2[i,j].y+","+result_vec2[i,j].z+",");
				}

			}

			sw.Flush();
			sw.Close();
		}
    }

	void textSave(Vector3[,] result_vec1,Vector3[,] result_vec2,int vec1_count, int vec2_count,string name){
		StreamWriter sw;
		FileInfo fi;
		fi = new FileInfo(Application.dataPath + "/FileName.csv");

		sw = fi.AppendText ();

		for (int i = 0;i<max_num; i++) {
			for (int j = 0;j<vec1_count;j++) {
				sw.WriteLine(result_vec1[i,j].x+","+result_vec1[i,j].y+","+result_vec1[i,j].z+",");
				Debug.Log(result_vec1[i,j].x+","+result_vec1[i,j].y+","+result_vec1[i,j].z+",");
			}
			for (int j = 0;j<vec2_count;j++) {
				sw.WriteLine(result_vec2[i,j].x+","+result_vec2[i,j].y+","+result_vec2[i,j].z+",");
				Debug.Log(result_vec2[i,j].x+","+result_vec2[i,j].y+","+result_vec2[i,j].z+",");
			}

		}

		sw.Flush();
		sw.Close();
	}
}

