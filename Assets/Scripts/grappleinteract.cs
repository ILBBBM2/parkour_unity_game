using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class grappleinteract : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public string grappleinteractshit;
    public void baseinteract(){
        Interact();
    }

    // Update is called once per frame
    void Update()
    {
    }
    protected virtual void Interact(){
        //nutting here
    }
}
