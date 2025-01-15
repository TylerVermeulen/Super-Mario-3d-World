using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToCameraList : MonoBehaviour
{
    private GameObject cam;
    void Awake()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        cam.GetComponent<CameraFollow>().Targets.Add(this.transform);
    }
}
