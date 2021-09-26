using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float sensX;
    [SerializeField] private float sensY;

    Camera playerCam;

    float mouseX;
    float mouseY;

    float camMultiplier = 0.01f;

    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    private void Start()
    {
        playerCam = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        GetInput();
        playerCam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    void GetInput()
    {
        mouseX = Input.GetAxisRaw("Mouse X");
        mouseY = Input.GetAxisRaw("Mouse Y");

        yRotation += mouseX * sensX * camMultiplier;
        xRotation -= mouseY * sensY * camMultiplier;

        xRotation = Mathf.Clamp(xRotation, -1f, 1f);
    }
}
