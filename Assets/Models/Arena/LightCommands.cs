using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCommands : MonoBehaviour
{

    public float ScrollX = 0.0f;
    public float ScrollY = 0.0f;

    void Update()
    {
        float OffsetX = Time.time * ScrollX;
        float OffsetY = Time.time * ScrollY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
        
    }
}
