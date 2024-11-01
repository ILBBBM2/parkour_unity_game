using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 lookdir;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lookdir = transform.forward;
    }
}
