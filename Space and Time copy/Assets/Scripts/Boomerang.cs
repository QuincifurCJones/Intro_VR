using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    [SerializeField] float fly_timer = 2.0f;
    public GameObject Target_hand;
    float t_move = 0.0f;
    //eventually make a firing script that allows you to charge a throw position and send the boomerang based on the distance

    // Update is called once per frame
    void Update()
    {
        fly_timer -= Time.deltaTime;
        if(fly_timer <= 0)
        {
            //return to Target hand
            transform.position = Vector3.Lerp(transform.position, Target_hand.transform.position, t_move);
            t_move+= Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Hand")
        {
            Target_hand = other.gameObject;
        }
    }
}
