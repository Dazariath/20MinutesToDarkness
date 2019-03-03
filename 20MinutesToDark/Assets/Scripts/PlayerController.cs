﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    [SerializeField] private float lookSensitivity = 3f;

    private PlayerMove movePlayer;

    void Start()
    {
        movePlayer = GetComponent<PlayerMove>();
    }

    void Update()
    {
        //movement
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizonatal = transform.right * xMove;
        Vector3 moveVertical = transform.forward * zMove;

        Vector3 velocity = (moveHorizonatal + moveVertical).normalized * speed;

        movePlayer.Move(velocity);

        //Player Rotation
        float yRot = Input.GetAxisRaw("Mouse X");
        Vector3 _rotation = new Vector3(0f, yRot, 0f) * lookSensitivity;

        movePlayer.Rotate(_rotation);

        //Camera Rotation
        float xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 _cameraRotation = new Vector3(xRot, 0f, 0f) * lookSensitivity;

        movePlayer.RotateCamera(_cameraRotation);

    }


}