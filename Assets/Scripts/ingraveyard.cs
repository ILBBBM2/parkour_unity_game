using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingraveyard : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isingraveyard = false;
    void OnTriggerEnter(Collider other){
        isingraveyard = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
