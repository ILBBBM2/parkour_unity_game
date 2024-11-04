
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using System.Runtime.Serialization;
using JetBrains.Annotations;
using UnityEngine.Rendering;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    public Vector3 playerVelocity;
    public Transform camtrans;
    public Transform player;
    private bool IsGrounded;
    public float speed = 8f;
    public float gravity = -9.8f;
    public float jumpHeight = 1.49f;
    bool crouching = false;
    public float crouchTimer = 1;
    bool lerpCrouch = false;
    public bool DJ = true;
    public bool dashh = false;
    public float dashTime = 0.25f;
    public float dashSpeed = 25;
    //dash values (do9nt ask why there are so many)
    public Vector3 moveDirection;

    public float maxDashTime = 0.25f;
    public float dashDistance = 10;
    public float dashStoppingSpeed = 0.5f;
    public float currentDashTime = 0.25f;
    public bool firstdash = true;
    public bool wallrunning;
    public bool exitwallrun;
    public float exitwalltime;
    public float maxexittime;
    public int wallrun_stop;
    public bool imfree;
    public int wallbool = 0;
    public bool walljump = false;
    //raycast shit
    public float controllerradius = 0.5f;
    public float leftcontrollerradius = 5.5f; 
    new Vector3 rayOrigin;
    //oh my go what the actual sigma bruh. what the actual frick bruh.shawy got that oddy atayayaya. keep thefrom one to five very dafrom one to five
    //aint no way bruhaint no fricking way bruh 
    new Vector3 leftrayOrigin;
    RaycastHit hit;
    RaycastHit grapplehit;
    public float hitfloat;
    public bool leftside = false;
    public bool rightside = false;
    //grapple raycast
    public LayerMask layer;
    public LayerMask enemylayer;
    public LayerMask enemylayer2;
    public LayerMask enemylayer3;
    public LayerMask enemylayer4;
    public LayerMask enemylayer5;
    public LayerMask enemylayer6;
    public LayerMask grapplepoint;
    Vector3 lookdir;
    public float NICK;
    public float grappletime;
    public bool grappling;
    public float maxgrappletime;
    public float grapplingdistance;
    public float realgrappledistance;
    public float grapplestoppingspeed;
    public Vector3 NIGGER;
    public Camera cam;
    public float distance = 5.0f;
    public PlayerLook script;
    CharacterController _controller;
    public bool grappleshit;
    public bool imgrapplingrn;
    public float grappledistance;
    public float grappletraveldistance;
    //audio
    public AudioSource soundPlayer;
    public AudioSource wakeupsoundPlayer;
    public bool hitenemy = false;
    
    public bool grave = false;
    Vector3 hookshotpos;
    public float hookshotspeed = 5f;
    public float hookshotspeedmulti = 2f;
    public float hookshotspeedmin = 5f;
    public float hookshotspeedmax = 200f;
    public Vector3 characterVelocitymomentum;
    public float extraspeed = 7f;
    public bool jumpinwhilegrappling = false;
    public bool wakeupsound = false;
    public LayerMask grapplelayer;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        controller = GetComponent<CharacterController>();
        leftside = false;
        rightside = false;
        grappling  = false;
        grappleshit = false;
        imgrapplingrn = false;
        grapplestoppingspeed = 0.04f;
        maxgrappletime = 0.5f;
        grappledistance = 50;
        playerVelocity.y =0;
        playerVelocity.x =0;
        
        playerVelocity.z =0;
        maxexittime = 20;
        dashh = false;
        wallrunning = false;
        wallrun_stop = 0;
        exitwallrun = false;
        currentDashTime = 1;
        dashDistance = 20;
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
        soundPlayer.volume = 0.2f;
        hookshotspeedmin = 6.29f;
        hookshotspeedmax = 222.5f;
        transform.position = new Vector3(-0.5450001f, 11.72f, -2.34f);
        hookshotspeedmulti = 3f;
    }

    // Update is called once per frame
    public Vector3 charactervelocity;

    RaycastHit testhit;
    void Update()
    {
        
        //Ray testray = new Ray(cam.transform.position, cam.transform.forward);
        //if (Physics.Raycast(testray, out testhit, Mathf.Infinity, enemylayer)){
        //    Debug.Log(testhit.transform.gameObject.name);   
        //}
        if(characterVelocitymomentum.magnitude >= 0f){
            float momentumdrag = 16f;
            characterVelocitymomentum -= characterVelocitymomentum * momentumdrag * Time.deltaTime;
            if(characterVelocitymomentum.magnitude < .0f){
                characterVelocitymomentum = Vector3.zero;
            }
        }
        float hookshotspeed = Mathf.Clamp(Vector3.Distance(transform.position, hookshotpos), hookshotspeedmin, hookshotspeedmax);
        Vector3 hookshotdir = (hookshotpos - transform.position).normalized;
        Ray grappleray = new Ray(cam.transform.position, cam.transform.forward);
        
        if(Vector3.Distance(transform.position, hookshotpos) < 1.5f){

            imgrapplingrn = false;
            jumpinwhilegrappling = false;
        }
        if(imgrapplingrn){
            
            playerVelocity.y = 0;
            //hookshotpos = grapplehit.point;
            controller.Move(hookshotdir * hookshotspeed * hookshotspeedmulti * Time.deltaTime);
        }
        extraspeed = 0.001f;
        if(jumpinwhilegrappling){
            characterVelocitymomentum = hookshotdir * hookshotspeed * extraspeed;
            jumpinwhilegrappling = false;
        }
        //if(imgrapplingrn){
        //    controller.Move(hookshotdir * hookshotspeed * Time.deltaTime);
        //}
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        
        Debug.DrawRay(grappleray.origin, grappleray.direction * grappledistance);
        ray.GetPoint(10);
        NIGGER = ray.GetPoint(10.0f);
        //Debug.Log(NIGGER);

        if (grappling){
            script.fenttrip(1);
            script.ySens = -13;
            script.xSens = -13;
            script.DoFov();
        }

        if(sensupbool){
            script.xSens += 1;
            script.ySens += 1;
            sensupbool = false;
        }else if (sensdownbool){
            script.xSens -= 1;
            script.ySens -= 1;
            sensdownbool = false;
        }
        Ray shoot = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit shoothit;
        if(hitenemy){
            if(Physics.Raycast(shoot, out shoothit, 60, enemylayer)){
                //grave = true;
                //Destroy(shoothit.transform.gameObject);
                shoothit.transform.position = new Vector3(-826,16.8799992f,-1702.76001f);
            }
            
            hitenemy = false;
        }
        IsGrounded = controller.isGrounded;
        if(lerpCrouch){
            crouchTimer += Time.deltaTime;
            float p = crouchTimer / 1;
            p *= p;
            if(crouching)
                controller.height = Mathf.Lerp(controller.height, 1,p);
            else
                controller.height = Mathf.Lerp(controller.height, 2, p);
            if (p>1){
                lerpCrouch = false;
                crouchTimer = 0f;
            }
        }
        if (IsGrounded){
            DJ = true;
            dashh = true;
        }
        //i like big cox iin my mouth
        if(!wallrunning){
            speed = 6.9420f;
            wallrun_stop = 0;
            leftside = false;
            rightside = false;
        }else if (wallrunning && speed < 12){
            speed += 1;
        }
        //speed = 6.9420f;
        //dash shit
        dashStoppingSpeed = 0.04f;
        maxDashTime = 0.5f;
        dashDistance = 20;
        if(currentDashTime < maxDashTime)
        {
            moveDirection = transform.forward * 10;
            currentDashTime += dashStoppingSpeed;
            soundPlayer.Play();
        }else{
            moveDirection = Vector3.zero;
        }
        //if(imgrapplingrn){
        //    if(grappletime < maxgrappletime){
        //        moveDirection = camtrans.transform.forward * realgrappledistance;
        //        grappletime += grapplestoppingspeed;
        //    }else{
        //        imgrapplingrn = false;
        //    }
        //}
        //more raycast shitz
        
        if(exitwallrun){
            while (exitwalltime < maxexittime -1){
                exitwalltime += 1;
            }
        }
        if(exitwalltime > maxexittime){
            exitwallrun = false;
        }

        controller.Move(moveDirection * 0.01f * dashSpeed);
        //raycast
        rayOrigin = transform.position + transform.right * controllerradius;
        if(Physics.Raycast(rayOrigin, transform.right, out hit, 1)){
            //Debug.Log("right raycast hit");
            rightside = true;
        }else if (Physics.Raycast(rayOrigin, transform.forward * 0.5f, out hit, 5)){
            //Debug.Log("hmm");
        }else{
            rightside = false;
        }
        
        leftrayOrigin = transform.position - transform.right * controllerradius;
        if (Physics.Raycast(leftrayOrigin, transform.right * -1, out hit, 1)) {
            //Debug.Log("left raycast hit");
            leftside = true;
        }else{
            leftside = false;
        }
        Debug.DrawRay(rayOrigin, transform.right);
        Debug.DrawRay(leftrayOrigin, transform.right * -1);
        //Debug.Log(ray.direction * distance);
    }
    public void Crouch(){
        crouching = !crouching;
        crouchTimer = 0;
        lerpCrouch = true;
    }
    //get the input from input manager script and apply to character controller
    public void ProcessMove(Vector2 input){
        Vector3 moveDirection = Vector3.zero;
        Vector3 othercharactervelocity = transform.TransformDirection(moveDirection) * speed * Time.deltaTime;
        othercharactervelocity += characterVelocitymomentum;
        controller.Move(transform.TransformDirection(moveDirection) * characterVelocitymomentum.magnitude);
        //if(characterVelocitymomentum.magnitude >= 0f){
        //    float momentumdrag = 7f;
        ///    characterVelocitymomentum -= characterVelocitymomentum * momentumdrag * Time.deltaTime;
        //    if(characterVelocitymomentum.magnitude < .0f){
        //        characterVelocitymomentum = Vector3.zero;
        //    }
        //}
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        charactervelocity = transform.right * input.x * speed + transform.forward * input.y * speed;
        
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if (IsGrounded && playerVelocity.y < 0){
            playerVelocity.y = -2f;  
        }else if(!IsGrounded){
            //Debug.Log("in air");
        }
        /*if ((controller.collisionFlags & CollisionFlags.Sides) != 0 && !IsGrounded){
            wallrunning =  true;
            playerVelocity.y = 0;
            wallrun_stop += 1;
        }else{
            wallrunning = false;
        }*/
        if (rightside && !IsGrounded && !walljump && imfree){
            wallrunning = true;
            exitwallrun = false;
            exitwalltime = 0;
            DJ = true;
            playerVelocity.y = 0;
            script.DoTilt(5f);
            
        }else if (leftside && !IsGrounded && !walljump && imfree){
            wallrunning = true;
            exitwallrun = false;
            exitwalltime = 0;
            DJ = true;
            playerVelocity.y = 0;
            script.DoTilt(-5f);
            
        }else{
            wallrunning = false;
            script.DoTilt(0);
            
            if (exitwalltime <= 50){
                exitwalltime += 1;
                imfree = false;
            }else if (exitwalltime > 49){
                imfree = true;
            }
            wallbool = 1;
            walljump = false;
        }
        controller.Move(playerVelocity * Time.deltaTime);
        //Debug.Log(playerVelocity.y);
    }
    public void Jump(){
        if (IsGrounded){
            //the 1.49f is the jumpheight change later
            playerVelocity.y = Mathf.Sqrt(1.49f * -3.0f * gravity);
        }
        if(wallrunning){
            walljump = true;
            playerVelocity.y = Mathf.Sqrt(1.49f * -3.0f * gravity);
        }
        jumpinwhilegrappling = true;
        imgrapplingrn = false;
    }
    public void dash(){
        if(firstdash){
            dashh = true;
            firstdash = false;
        }
        if (dashh){
            currentDashTime = 0;
            dashh = false;
        }
    }
    public void DoubleJump(){
        if (DJ == true){
            playerVelocity.y = Mathf.Sqrt(1.49f * -3.0f * gravity);
            DJ = false;
        }
        jumpinwhilegrappling = true;
        imgrapplingrn = false;
    }
    public void fent(){
        /*Vector3 playerpos = transform.position;
        Vector3 forwarddir = transform.forward;
        Ray grappleray = new Ray(playerpos, script.lookdir);
        RaycastHit grapplehit;
        float grappleraylength = 5.0f;
        Vector3 grappleendpoint = script.lookdir * grappleraylength;
        Debug.DrawLine(playerpos, grappleendpoint);*/
        grappling = true;
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        
            
        transform.forward = ray.direction * 10000;                
        NICK = 0;
        
        
    }
    public void grapple(){
        //grappleshit = true;
        //grappletime = 0;
        //realgrappledistance = 35f;
        //Ray grappleray = new Ray(cam.transform.position, cam.transform.forward);
        ////Physics.Raycast(grappleray.origin, camtrans.transform.forward, out grapplehit, grappledistance, layer)
        //if(Physics.Raycast(grappleray, out grapplehit, grappledistance, layer)){   
        //    if(grapplehit.collider.GetComponent<grappleinteract>().grappleinteractshit != null){
        //        imgrapplingrn = true;
        //        //Debug.Log("NIGGGGGGGERRRR");
        //    }
        //}
        //if(Physics.Raycast(grappleray, out grapplehit, grappledistance)){
        //    imgrapplingrn = true;
        //    hookshotpos = grapplehit.point;
        //}
        Ray niggrappleray = new Ray(cam.transform.position, cam.transform.forward);
        imgrapplingrn = true;
        if(Physics.Raycast(niggrappleray, out grapplehit, grappledistance,enemylayer)){
                //Debug.Log("it works");
                hookshotpos = grapplehit.point;
                imgrapplingrn = true;
                //controller.Move(hookshotdir * hookshotspeed * Time.deltaTime);
        }else{
            hookshotpos = transform.position;
        }
        
        //if(wtv){
        //    Debug.Log(grapplehit.transform.gameObject.name + "NIGGA");
        //    wtv = false;
        //}
    }
    public bool sensupbool;
    public bool sensdownbool;
    public void sensup(){
        sensupbool = true;
    }
    public void sensdown(){
        sensdownbool = true;
    }
    public void shoot(){
        //Ray shoot = new Ray(cam.transform.position, cam.transform.forward);
        //RaycastHit shoothit;
        //if(Physics.Raycast(shoot, out shoothit, 60, enemylayer)){
            //GameObject lmao = hit.transform.gameObject;
            //Debug.Log("Clicked on " + shoothit.transform.gameObject.name); 
            //Destroy(hit.collider.gameObject);
            hitenemy = true;
        //}        
        
    }
}

