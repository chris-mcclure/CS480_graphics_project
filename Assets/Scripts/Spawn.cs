using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject ball;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            {
                Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                { 
                    Instantiate(ball, hit.point, Quaternion.identity);
                }
            }
        }
	}
}
