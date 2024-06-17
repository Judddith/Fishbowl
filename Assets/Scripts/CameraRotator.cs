using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public Camera cam;
    private Vector3 previousPosition;
    public GameObject dome;
    private Vector3 domePosition;
    
    // Start is called before the first frame update
    void Start()
    {
        domePosition = GameObject.Find("GlassDome").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0)) {
            Vector3 direction = previousPosition - cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.position = new Vector3();

            cam.transform.Rotate(new Vector3(1,0,0), direction.y * 180);
            cam.transform.Rotate(new Vector3(0,1,0), -direction.x * 180, Space.World);
            cam.transform.Translate(new Vector3(0,0,-150));

            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);

            if (cam.transform.rotation.x >= 90) {
                cam.transform.rotation = new Quaternion(90,cam.transform.rotation.y,cam.transform.rotation.z,0);
        
            }
        }
        Console.WriteLine(cam.transform.rotation);
    }
}
