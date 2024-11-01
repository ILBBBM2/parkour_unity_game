using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathteleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public lvl2triigger script;
    public enemyenable enemy;
    public bool working = false;
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
        thePlayer.transform.position = teleportTarget.transform.position;
        
        enemy.enemy_enable = true;
        enemy.respawn = true;
        working = true;
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {




    }
}
