using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{


    private float moveSpeed = 0.5f;
    private float scrollSpeed = 10f;
    //public Vector3D startPosition = new Vector3D(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Camera";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) {
            transform.position += moveSpeed * new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0) {
            transform.position += scrollSpeed * new Vector3(0, 0, -Input.GetAxis("Mouse ScrollWheel"));
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            transform.position = new Vector3(0, 1, -10);
        }
    }
}


