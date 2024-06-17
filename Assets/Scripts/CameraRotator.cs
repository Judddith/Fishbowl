using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public Camera camOutside;
    public Camera camInside;

    public Camera cam;
    private Vector3 previousPosition;
    public GameObject dome;


    // Start is called before the first frame update
    void Start()
    {
        camOutside.enabled = true;
        camInside.enabled = false;
        Camera.main.transform.Translate(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        //controlls outside camera
        if (camOutside.enabled == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                previousPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            }
            if (Input.GetMouseButton(0))
            {
                Vector3 direction = previousPosition - Camera.main.ScreenToViewportPoint(Input.mousePosition);

                Camera.main.transform.position = new Vector3();

                Camera.main.transform.Rotate(new Vector3(1, 0, 0), direction.y * 180);
                Camera.main.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180, Space.World);
                Camera.main.transform.Translate(new Vector3(0, 0, -150));

                previousPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

                // if (cam.transform.rotation.x >= 90) {
                //     cam.transform.rotation = new Quaternion(90,cam.transform.rotation.y,cam.transform.rotation.z,0);

                // }
            }
        }

        //controls inside camera
        if (camInside.enabled == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Console.Write("camInside");
                Vector3 direction = previousPosition - Camera.main.ScreenToViewportPoint(Input.mousePosition);


            }
            if (Input.GetMouseButton(0))
            {
                Vector3 direction = previousPosition - Camera.main.ScreenToViewportPoint(Input.mousePosition);

                Camera.main.transform.position = new Vector3();

                Camera.main.transform.Rotate(new Vector3(1, 0, 0), direction.y * 180);
                Camera.main.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180, Space.World);
                Camera.main.transform.Translate(new Vector3(0, 0, 0));

                previousPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

            }

        }

        //toggles inner and outer camera
        if (Input.GetKeyDown(KeyCode.C))
        {
            camOutside.enabled = !camOutside.enabled;
            camInside.enabled = !camInside.enabled;
        }
    }
}
