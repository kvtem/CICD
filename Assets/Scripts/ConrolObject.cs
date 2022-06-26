using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConrolObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //demo 02
        if (Input.GetMouseButtonUp(0)) transform.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0, 1);
    }
}
