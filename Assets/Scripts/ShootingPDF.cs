using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPDF : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Camera playerCam;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate(this.bulletPrefab);
            bulletObject.transform.position = playerCam.transform.position + transform.forward;
            bulletObject.transform.forward = playerCam.transform.forward;
        }
    }
}
