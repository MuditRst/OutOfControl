using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Transform spawnPoint;
    public float speed = 5f;
    public Rigidbody2D rb;
    //public Animator anim;
    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
       // anim.SetFloat("horizontal",movement.x);
       // anim.SetFloat("vertical",movement.y);
       // anim.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.name == "BaseBall"){
            speed = 20f;
            GameObject.Find("CurrentWeapon").GetComponent<Shooting>().enabled = true;
        }
    }
}
