using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Bullet;
    public Transform aimTrans;
    public Transform firePoint;
    public float bulletForce = 20f;
    public Camera cam;
    void Awake(){
        aimTrans = firePoint.transform;
    }
    void Update()
    {  
        aim();
        shoot();
    }

    void aim(){
        Vector3 mouspos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 aimDir = (mouspos - transform.position).normalized;
        float angle = Mathf.Atan2(aimDir.y,aimDir.x) * Mathf.Rad2Deg;
        aimTrans.eulerAngles = new Vector3(0,0,angle);
    }

    void shoot(){
        if(Input.GetButtonDown("Fire1")){
            Soundmanager.PlaySound("ShootSound");
            GameObject bulletPrefab = Instantiate(Bullet,firePoint.position,firePoint.rotation);
            Rigidbody2D rb =  bulletPrefab.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.right * bulletForce,ForceMode2D.Impulse);

            Destroy(bulletPrefab,1f);
        }
    }
}
