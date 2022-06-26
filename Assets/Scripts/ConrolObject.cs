﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConrolObject : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Demo 01
        RotateObject();
    }

    void RotateObject() => transform.Rotate(Vector3.up, Time.deltaTime * speed);

}
