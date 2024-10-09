using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime_decay : MonoBehaviour
{
    // Start is called before the first frame update
    public float lifetime = 5.0f;

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;

        if (lifetime < 0)
        {
            Destroy(gameObject);
        }
    }
}
