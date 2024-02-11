using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAbility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
           
        
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Destroy(gameObject, 6.0f);
        }
    }
    

}
