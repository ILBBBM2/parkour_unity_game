using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increase_sens : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerLook script;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other){
            script.xSens += 1;
            script.ySens += 1;
    }
}
