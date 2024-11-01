using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float speed = 9f;
    public enemyenable script;
    public PlayerMotor main;
    // Start is called before the first frame update
    public CharacterController controller;
    public Transform target;
    public Transform spawnlocation;
    public ingraveyard grave;
    public bool turnoffrespawn = false;
    Vector3 movedir = Vector3.zero;
    void Start()
    {
        speed = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        if(grave.isingraveyard){
            //main.grave = true;
            script.enemy_enable = false;
            transform.position = new Vector3(-826,16.8799992f,-1702.76001f);
            
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
            transform.position = spawnlocation.transform.position;
            script.enemy_enable = true;
            main.grave = false;
            script.respawn = false;
            grave.isingraveyard = false;
        }
        
    }
}
