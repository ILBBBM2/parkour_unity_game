using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    public Transform camholder;
    public float xRotation = 0f;
    public float xSens = 13f;
    public float ySens = 13f;
    public Vector3 lookdir;
    // Start is called before the first frame update
    void Start(){
        xSens = 13;
        ySens = 13;
    }
    public void ProcessLook(Vector2 input){
        float mouseX = input.x;
        float mouseY = input.y;
        //calculation for the mouse x movements
        xRotation -= mouseY * 0.0167f * ySens;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //just copied this shit lmao
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.Rotate(Vector3.up * (mouseX * 0.0167f) * xSens);
    }
    void Update(){
        
    }
    public void DoTilt(float zTilt){
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        camholder.transform.DOLocalRotate(new Vector3(0, 0, zTilt), 0.25f);
        lookdir = new Vector3 (xRotation, 0, zTilt);
    }
    public void fenttrip(float fent){
        if(fent < 50){
            fent += 1;
        }else{
            fent = 0;
        }
        
        camholder.transform.DOLocalRotate(new Vector3(0,0,fent), 0.25f);
    }
    bool fenting = false;
    public void DoFov(){
        if(!fenting){
            for(int fov = 10; fov < 150; fov ++){
                cam.DOFieldOfView(fov, 0.25f);
                fenting = true;
            }
        }
        if(fenting){
            for(int fov = 10; fov < 150; fov ++){
                cam.DOFieldOfView(fov, 0.25f);
                fenting = false;
            }
        }
    }
    
}
      

