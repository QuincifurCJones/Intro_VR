using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class Fire_bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject Bullet;
    public InputActionReference trigger;
    public float shoot_power = 200.0f;
    public AudioClip shoot_sfx;

    void Start()
    {
        trigger.action.performed += shoot;
    }

    void shoot(InputAction.CallbackContext __)
    {
        GameObject new_bullet = Instantiate(Bullet, transform.position, transform.rotation);
        new_bullet.GetComponent<Rigidbody>().AddForce(transform.forward * shoot_power);
    
        //play audio
        //GetComponent<AudioSource>.AudioSource.Play();
    }
}
