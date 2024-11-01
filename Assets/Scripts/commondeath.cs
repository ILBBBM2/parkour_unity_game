using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commondeath : MonoBehaviour
{
    // Start is called before the first frame update
    public bool BRUH = false;
    void OnTriggerEnter(Collider other){
        BRUH = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
