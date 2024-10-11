using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;


public class Bullet_Hit : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int HP = 1;
    //[SerializeField] String Bullet_tag;
    [SerializeField] AudioSource my_audio_source;

    void Update()
    {
        if(HP <= 0)
        {
            //Destroy(gameObject);
            Destroy(transform.parent.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        
        Debug.Log("Enemy Hit!");
        
        if(other.CompareTag("Bullet"))
        {
            Debug.Log("it was a bullet");
            my_audio_source.Play();
            //Destroy(gameObject);
            HP -= 1;
        }//*/
        Destroy(other.gameObject);
    }
}
