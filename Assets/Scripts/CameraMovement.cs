using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 domePosition;
    private float moveSpeed = 0.5f;
    private float scrollSpeed = 10f;
    private float magnitude = 10f;
    public Camera cam;
    
    
    //public Vector3D startPosition = new Vector3D(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

    // Start is called before the first frame update
    void Start()
    {
        domePosition = GameObject.Find("GlassDome").transform.position;
        transform.position = new Vector3(310, 40, 400);
    }

    // Update is called once per frame
    void Update()
    {
        //always lets camera look at dome position
        transform.LookAt(domePosition);

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.position += moveSpeed * new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.position -= moveSpeed * new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0) {
            transform.position += scrollSpeed * new Vector3(0, 0, -Input.GetAxis("Mouse ScrollWheel"));
        }

    // R-Key resets camera position
        if (Input.GetKeyDown(KeyCode.R)) {
            //transform.position = new Vector3(310, 40, 400);
            //transform.rotation = Quaternion.Euler(18,0,0);
        }
    } 
}


