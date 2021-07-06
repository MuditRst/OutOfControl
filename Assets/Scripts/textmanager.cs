using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textmanager : MonoBehaviour
{
    private float timer = 2f;
    public Text text;
    private float textdisappear;

    void Start(){
        text.enabled = false;
        textdisappear = Time.time + timer;
    }

    void Update(){
        if(!text.enabled && Time.time >= textdisappear){
            text.enabled = true;
        }
    }
    
}
