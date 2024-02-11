using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLaunch : MonoBehaviour
{

    public Rigidbody Missile;
    AudioSource launchsound;
    public float speed;
    public float Yangle;
    
    // Start is called before the first frame update
    void Start()
    {
        launchsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           launchsound.Play();
            //transform.localPosition = Vector3.MoveTowards(transform.localPosition, PositionB, Time.deltaTime * speed);
            Rigidbody g = Instantiate(Missile, transform.position, transform.rotation);
            g.transform.Rotate(0.0f, Yangle, 0.0f);
            g.velocity = transform.right * speed;
            Destroy(gameObject, 1.0f);
            Destroy(g, 2.0f);
        }
    }
}
