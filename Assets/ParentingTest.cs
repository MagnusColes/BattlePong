using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentingTest : MonoBehaviour
{


    public Transform parent;
    public Vector3 position;
    public Quaternion rotation;
    public GameObject child;
    // Start is called before the first frame update
    void Start()
    {
        GameObject childGameObject = Instantiate(child, parent);
        childGameObject.name = "Child";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
