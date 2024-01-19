using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float mouseSens = 100f;
    public Transform player;
    public float rotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player = transform.parent;
    }


    void Update()
    {
        CameraRotation();
    }

    public void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        rotation = mouseY;

        //ten fragment przepisa³am z naszego poprzedniego projektu, poniewa¿ niestety nie dzia³a³o kiedy robi³am to sama
        rotation = Mathf.Clamp(rotation, -90f, 80f);

        transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
