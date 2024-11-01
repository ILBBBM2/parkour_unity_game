using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class lookat : MonoBehaviour
{
    public float speed = 9f;
    public enemyenable script;
    public PlayerMotor main;
    // Start is called before the first frame update
    public CharacterController controller;
    public Transform target;
    public Transform spawnlocation;
    public Transform gravelocation;
    public ingraveyard grave;
    //public commondeath death;
    public bool turnoffrespawn = false;
    Vector3 movedir = Vector3.zero;
    void Start()
    {
        speed = 7f;
    }
    public bool lmao = false;
    // Update is called once per frame
    void Update()
    {
        //if(death.BRUH){
        //    transform.position = gravelocation.transform.position;
        //}
        //if(main.grave){
        //    transform.position = gravelocation.transform.position;
        //}
        if(grave.isingraveyard){
            //main.grave = true;
            script.enemy_enable = false;
            //transform.position = new Vector3(-826,16.8799992f,-1702.76001f);
            
        }
        if(script.enemy_enable){
            transform.LookAt(target);
            movedir = transform.forward;
            controller.Move(transform.TransformDirection(movedir) * speed * Time.deltaTime);
        }
        Vector3 wow = new Vector3(-826,16.8799992f,-1702.76001f);
        
        //if(main.grave){
        //    grave.isingraveyard = false;
        //    script.enemy_enable = false;
        //    transform.position = new Vector3(-826,16.8799992f,-1702.76001f);
        //}
        
        if(script.respawn){
            Debug.Log(transform.gameObject.name + ": is respawning");
            transform.position = spawnlocation.transform.position;
            script.enemy_enable = true;
            main.grave = false;
            grave.isingraveyard = false;
            //death.BRUH = false;
            lmao = true;
            script.respawn = false;
            //grave.isingraveyard = false;
        }
        
        
    }
}
