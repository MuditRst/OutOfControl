using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPlayer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col){
        if(col.collider.tag == "Player"){
            Destroy(col.gameObject);
        }
    }
}
