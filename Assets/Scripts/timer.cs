using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public int wow;
    public string lmao;
    public Text textlmao;
    void Start(){
        float duration = 1f;
        StartCoroutine(TestRoutine(duration));
        textlmao.transform.position = new Vector3(110,300,0);
    }
    IEnumerator TestRoutine(float duration){
        while (1 == 1){
            //Debug.Log($"Started at {Time.time}, waiting for {duration} seconds");
            yield return new WaitForSeconds(duration);
            wow += 1;
            //Debug.Log($"Ended at {Time.time}");
        }
    }
    void Update(){
        lmao = $"timer: {wow}";
        textlmao.text = lmao;
    }

}
