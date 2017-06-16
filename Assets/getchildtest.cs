using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class getchildtest : MonoBehaviour
{
    // Use this for initialization
    public GameObject unity_chan2;
    public List<GameObject> list1,list2;

    void Start()
    {
        list1 = GetAllChildren.GetAll(gameObject);
        list2 = GetAllChildren.GetAll(unity_chan2);
    }
    void Update()
    {
        for(int i =0;  list1.Count>i; i++)
        {
            list2[i].transform.position = list1[i].transform.position + unity_chan2.transform.position;
            list2[i].transform.rotation = list1[i].transform.rotation;
        }
    }
}