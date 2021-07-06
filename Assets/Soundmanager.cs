using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanager : MonoBehaviour
{
    public static AudioClip Shooting,powerup;
    static AudioSource audsrc;
    void Start()
    {
        Shooting = Resources.Load<AudioClip>("ShootSound");
        powerup = Resources.Load<AudioClip>("Powerup");

        audsrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip){
        switch(clip){
            case "ShootSound": 
                audsrc.PlayOneShot(Shooting);
                break;
            case "Powerup":
                audsrc.PlayOneShot(powerup);
                break;
        }
    }
}
