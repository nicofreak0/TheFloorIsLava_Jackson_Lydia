using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeColor : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[6];
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Paddle")
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[2];
        }
    }
}