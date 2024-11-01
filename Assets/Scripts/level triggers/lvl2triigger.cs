using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2triigger : MonoBehaviour
{
    // Start is called before the first frame update
    public bool islevel2 = false;
    void OnTriggerEnter (Collider other){
        islevel2 = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
