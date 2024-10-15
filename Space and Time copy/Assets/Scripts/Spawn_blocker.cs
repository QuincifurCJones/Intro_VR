using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;


public class Spawn_blocker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject Blocker;
    public InputActionReference trigger;
    public float distance_scale = 1.0f;

    void Start()
    {
        trigger.action.performed += shoot;
    }

    void shoot(InputAction.CallbackContext __)
    {
        GameObject new_bullet = Instantiate(Blocker, transform.position + (transform.forward*distance_scale), transform.rotation);
        //play audio
        //GetComponent<AudioSource>.AudioSource.Play();
    }
}
