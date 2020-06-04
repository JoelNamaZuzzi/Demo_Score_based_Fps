using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    
    public InputMaster controls;

    void Awake ()
    {
        controls.Player.Shoot.performed += ctx => Shoot();
        controls.Player.Movement.performed += _ => Move();
    }

    void Move()
    {
        Debug.Log("player wanna move");
        

    }
    
    void Shoot()
    {
        Debug.Log("SHOOT");

    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    
    
}
