using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundingBox : MonoBehaviour {
    public GameObject shape;
    // Use this for initialization
    void Start()
    {
        Vector3 boxsize = shape.GetComponent<Renderer>().bounds.size;
        drawBox(boxsize);
    }

    void drawBox(Vector3 bsize)
    {
        Debug.Log(bsize.x);
        Debug.Log(bsize.y);
        Debug.Log(bsize.z);
    }
}
