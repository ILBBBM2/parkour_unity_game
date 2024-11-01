using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textshow : MonoBehaviour
{
    public string lmao;
    public PlayerLook script;
    public Text textlmao;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        lmao = $"mouse sens: {script.ySens}";
        textlmao.text = lmao;
    }
}
