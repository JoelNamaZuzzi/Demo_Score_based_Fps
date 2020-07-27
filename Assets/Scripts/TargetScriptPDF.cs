using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScriptPDF : MonoBehaviour
{

    public GameObject player;
    private void OnCollisionEnter(Collision other){

        if (other.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            Debug.Log(player.GetComponent<ScorePDF>()._score+= 100);
            Destroy(gameObject);
        }
    
    }
}
