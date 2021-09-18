using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]

    public float movementSpeed = 6f;
    public float movementMultiplier = 10f;

    float horizontalMovement;
    float verticalMovement;

    Vector3 movementDirection;

    Rigidbody player;

    // Start is called before the first frame update
    private void Start()
    {
        player = GetComponent<Rigidbody>();
        player.freezeRotation = true;
    }

    // Update is called once per frame
    private void Update()
    {
        GetInput();
        ControlDrag();
    }

    void ControlDrag()
    {
        player.drag = 6f;
    }

    void GetInput()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

        movementDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        player.AddForce(movementDirection.normalized * movementSpeed * movementMultiplier, ForceMode.Acceleration);
    }
}

