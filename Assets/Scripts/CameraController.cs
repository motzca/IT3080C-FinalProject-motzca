using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 250f;
    public Transform player;

    private float xRotationCamera = 0f;

    void Start()
    {
    }

    void Update()
    {
        // get mouse movements
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;;

        //Cam up and down
        player.Rotate(Vector3.up * mouseX);
        //Cam left and right
        transform.localRotation = Quaternion.Euler(xRotationCamera, 0f, 0f);
        xRotationCamera -= mouseY;
        xRotationCamera = Mathf.Clamp(xRotationCamera, -90f, 90f);
    }
}
