using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerNIGGER : MonoBehaviour
{
    // Start is called before the first frame updat
    public sounder script;
    public bool bruh = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        bruh = true;
        //this shit cant be real bruh. ong or no cap
        
        if(bruh){
            script.nickgurh =  true;
            bruh = false;
        }
        
    }
}
