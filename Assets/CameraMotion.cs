﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour {

    public GameObject player = null;
    private Vector3 offset = Vector3.zero;

    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("unitychan");
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = player.transform.position.x + offset.x;
        newPosition.y = player.transform.position.y + offset.y;
        newPosition.z = player.transform.position.z + offset.z;
        transform.position = newPosition;
    }
}