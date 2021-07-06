using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerAttack : MonoBehaviour
{
    public Transform attackpoint;
    public float attackrange = 0.5f;

    public GameObject attackPrefab;

    public LayerMask enemies;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            attack();
            GameObject effect =  Instantiate(attackPrefab,attackpoint.position,attackpoint.rotation);
            Destroy(effect,0.1f);
        }

    }

    void attack(){

       Collider2D[] hitenem =   Physics2D.OverlapCircleAll(attackpoint.position,0.5f,enemies);
        if(transform.Find("CurrentWeapon").GetComponent<SpriteRenderer>().sprite != null){
            foreach(Collider2D enemy in hitenem){
           Destroy(enemy.gameObject);
            }
       }
    }
}
