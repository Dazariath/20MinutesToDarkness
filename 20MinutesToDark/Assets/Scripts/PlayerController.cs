using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    [SerializeField] private float lookSensitivity = 3f;

    private PlayerInputDetection input;

    void Start()
    {
        input = GetComponent<PlayerInputDetection>();   
    }

    void Update()
    {
        //movement
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizonatal = transform.right * xMove;
        Vector3 moveVertical = transform.forward * zMove;

        Vector3 velocity = (moveHorizonatal + moveVertical).normalized * speed;

        input.Move(velocity);

        //Player Rotation
        float yRot = Input.GetAxisRaw("Mouse X");
        Vector3 _rotation = new Vector3(0f, yRot, 0f) * lookSensitivity;

        input.Rotate(_rotation);

        //Camera Rotation
        float xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 _cameraRotation = new Vector3(xRot,0f, 0f) * lookSensitivity;

        input.RotateCamera(_cameraRotation);

    }


}
