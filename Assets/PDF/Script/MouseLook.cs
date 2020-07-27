using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.Mathematics;

public class MouseLook : MonoBehaviour
{
    public float mousSensitivity = 100f;

    public Transform playerBody;

    private float xrot = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * mousSensitivity * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mousSensitivity * Time.deltaTime;

        xrot -= mousey;
        xrot = Mathf.Clamp(xrot, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xrot, 0f, 0f);
        playerBody.Rotate(Vector3.up*mousex);
    }
}
