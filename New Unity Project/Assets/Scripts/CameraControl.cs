using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float sensX;
    [SerializeField] private float sensY;

    public GameObject counter;
    public Button x;
    public Button y;

    Camera playerCam;
    Camera zoomCam;

    float mouseX;
    float mouseY;

    float camMultiplier = 0.01f;

    float xRotation;
    float yRotation;

    //bool isRotating = true;

    // Start is called before the first frame update
    private void Start()
    {
        playerCam = Camera.main;
        Button btn = x.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Button btn1 = y.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);
        zoomCam = GameObject.Find("zoomCamera").GetComponent<Camera>();
        zoomCam.enabled = false;
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

        xRotation = Mathf.Clamp(xRotation, -0.1f, 0.1f);
    }


    void TaskOnClick()
    {
        zoomCam.enabled = true;
        zoomCam.transform.position = new Vector3(zoomCam.transform.position.x + 1, zoomCam.transform.position.y, zoomCam.transform.position.z - 1);
    }

    void TaskOnClick1()
    {
        var pos = counter.transform.position;
        zoomCam.enabled = false;
    }
}
