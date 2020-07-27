using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScriptPDF : MonoBehaviour
{

    public float speed = 10f;
    public float lifetime = 2f;

    public float lifetimer;
    void Start()
    {
        lifetimer = lifetime;
    }

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
