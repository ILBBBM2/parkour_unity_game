using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finaldoor : MonoBehaviour
{
    public PlayerMotor script;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(script.numoftriggers == 7){
            transform.position = new Vector3(345.609985f,49.8100014f,374.329987f);
        }
    }
}
