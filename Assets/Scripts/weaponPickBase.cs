using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponPickBase : MonoBehaviour
{
    public GameObject currentwep;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Player"){
            currentwep.GetComponent<SpriteRenderer>().sprite = GetComponent<SpriteRenderer>().sprite;
        }
        Destroy(gameObject);
    }
}
