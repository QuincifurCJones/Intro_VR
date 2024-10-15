using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waver_bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float scale = 1.0f;
    [SerializeField] float varience = 3.0f;
    float bullet_size = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bullet_size = ((float)Math.Sin(Time.deltaTime * Math.PI / 2) * scale) + varience;

        gameObject.transform.localScale = new Vector3(bullet_size, bullet_size, bullet_size);
    }
}
