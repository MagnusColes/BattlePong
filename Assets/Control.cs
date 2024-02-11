using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    public GameObject cannonPrefab;
    public GameObject machingunPrefab;
    public GameObject missilePrefab;
    public Transform parent;
    public Vector3 position;
    public Quaternion rotation;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        float speed = 5f;
        ////Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horrizontal"));

        //rbody.MovePosition(rbody.position + (movement_vector * speed) * Time.deltaTime);
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Cannon"))
            {
        
            Debug.Log("Cannon");
            Destroy(gameObject, 5.0f);
        }
        if (other.gameObject.CompareTag("Machine"))
        {
            GameObject childGameObject = Instantiate(machingunPrefab, parent);
            childGameObject.name = "MachineGun";
                        Debug.Log("Machine");
            
        }
        if (other.gameObject.CompareTag("Missile"))
        {
            GameObject childGameObject = Instantiate(missilePrefab, parent);
            childGameObject.name = "MissileFire";
            Debug.Log("Missile");
        }    
        //switch (GetComponent<Collider>().gameObject.name)
        //{
        //    case "Cannon":
        //        Debug.Log(gameObject.name);
        //        break;
        //    case "Bullets":
        //        Instantiate(machingunPrefab);
        //        break;
        //    case "Missile":
        //        Instantiate(missilePrefab);
        //        break;
        //}
       
    }
}
