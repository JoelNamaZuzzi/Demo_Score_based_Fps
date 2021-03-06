﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10f;

    public float lifetime=2f;

    private float lifetimer;
    // Start is called before the first frame update
    void Start()
    {
        lifetimer = lifetime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        lifetimer -= Time.deltaTime;

        if (lifetimer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Wall") ||
            other.gameObject.layer == LayerMask.NameToLayer("Target"))
        {
            Destroy(gameObject);
        }
    }
}
