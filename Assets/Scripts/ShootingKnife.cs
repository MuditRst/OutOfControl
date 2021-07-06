using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingKnife : MonoBehaviour
{

    public GameObject game;

    public string scr;
    void Start(){
        game= GameObject.Find("CurrentWeapon");
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col){
        if(GameObject.Find("CurrentWeapon").GetComponent<SpriteRenderer>().sprite != null){
           (game.GetComponent(scr) as MonoBehaviour).enabled = true;
        }else{
            (game.GetComponent(scr) as MonoBehaviour).enabled = false;
        }
    }
}
