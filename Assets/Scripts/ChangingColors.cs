using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColors : MonoBehaviour {

    void OnCollisionEnter(Collision col){
        if((col.gameObject.name == "Ball") || 
            (col.gameObject.tag == "Wall") ||
            (col.gameObject.name == "Ball(Clone)"))
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}
