using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{

    public GameObject player;
    private void OnCollisionEnter(Collision other){

        if (other.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            Debug.Log(player.GetComponent<Score>()._score+= 100);
            Destroy(gameObject);
        }
    
    }
}
