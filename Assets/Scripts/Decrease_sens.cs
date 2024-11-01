using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Decrease_sens : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI displayText;
    public PlayerLook script;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other){
        if(script.ySens > 1 && script.xSens > 1){
            script.ySens -= 1;
            script.xSens -= 1;
        }else {
            script.xSens = 1;
            script.ySens = 1;
        }
    }
}
