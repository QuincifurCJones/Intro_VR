using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int index = 0;
    [SerializeField]private float speed = 10f;
    [SerializeField] private GameObject Bullet;
    private GameObject playerTarget;
    private float targer_timer = 0.0f;
    private float shoot_timer = 5.0f;

    // When the player enters the trigger, assign it as a target
    private void OnTriggerEnter(Collider other) {
        playerTarget = other.gameObject;
        targer_timer = 4.0f;
    }

    // Update is called once per frame
    void Update()
    {
        targer_timer -= Time.deltaTime;
        shoot_timer  -= Time.deltaTime;
        // Only move forward if there is a player target
        if (playerTarget != null && targer_timer >= 0.1) 
        {
            transform.LookAt(playerTarget.transform.position);
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        if(shoot_timer <= 0)
        {
            
            switch(index)
            {
                case 1:
                    shoot_timer = 7.5f;
                    shoot();
                    break;

                default:
                    shoot_timer = 5.0f;
                    shoot();
                    break;
            }
        }
    }

    void shoot()
    {
        GameObject new_bullet = Instantiate(Bullet, transform.position+(transform.forward*2), transform.rotation);
        new_bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 150.0f);
    
        //play audio
        //GetComponent<AudioSource>.AudioSource.Play();
    }

    void spread_shoot()
    {
        GameObject new_bullet = Instantiate(Bullet, transform.position, transform.rotation);
        new_bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 150.0f);
    
    }
}
