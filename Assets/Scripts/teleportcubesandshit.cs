using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportcubesandshit : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMotor script;
    void OnTriggerEnter(Collider other){
        
    }
    void Update(){
        if(script.numoftriggers == 2){
            transform.position = new Vector3(345.609985f,49.8100014f,374.329987f);
        }
    }
}
