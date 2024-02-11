using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class FireProjectile : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 4;
    public float delay = 5;
    public float amount = 0;
    public float Xangle, Yangle, Zangle;
    private Vector3 shootDir;
    AudioSource m_shootingsound;

 

    public void Setup(Vector3 shootdir)
    {
        this.shootDir = shootdir;
        transform.eulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVector(shootdir));
        
    }
    
    void Start()
    {
        m_shootingsound = GetComponent<AudioSource>();
       
    }

    void Update() { StartCoroutine(CoolDown()); }
    // Update is called once per frame
   
     IEnumerator CoolDown()
        {
        if (Input.GetButtonDown("Fire1"))
        {
          
            m_shootingsound.Play();
            for (int i = 0; i < amount; i++) 
            {
              
                Rigidbody p = Instantiate(projectile, transform.position, transform.rotation);
                p.transform.Rotate(Xangle, Yangle, Zangle);
                p.velocity = transform.right * speed;
                yield return new WaitForSeconds(delay);
                
            }
        }
        }
    
}
