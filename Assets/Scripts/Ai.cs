using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    public GameObject target;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.transform.position - transform.position;
        direction.Normalize();
        movement = direction;
    }
    void FixedUpdate(){
        move(movement);
    }
    void move(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * movespeed * Time.deltaTime));
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag.Equals("BulletPlayer")){
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
