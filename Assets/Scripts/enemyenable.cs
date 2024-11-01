using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyenable : MonoBehaviour
{
    // Start is called before the first frame update
    public bool enemy_enable = false;
    public bool respawn = false;
    void OnTriggerEnter (Collider other){
        enemy_enable = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
