using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotting : MonoBehaviour
{
    public GameObject bulletprefab;

    public Camera playerCam;
    


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate(this.bulletprefab);
            bulletObject.transform.position = playerCam.transform.position + transform.forward;
            bulletObject.transform.forward = playerCam.transform.forward;
        }

    }
}
