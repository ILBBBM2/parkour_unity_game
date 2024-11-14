using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class sounder : MonoBehaviour
{
    public AudioSource soundPlayer;
    public PlayerMotor script;
    public bool nickgurh = false;
    public bool bruh = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nickgurh){
            script.wakeupsound = true;
            bruh = true;
        }
        if(bruh){
            nickgurh = false;
        }
    }
        
            
        
}
