using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionsSet : MonoBehaviour
{
    public GameObject rohrObject;
    public SphereCollider sphereCollider;

    public void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
    }

    public void Update()
    {
        if(gameObject.transform.position == rohrObject.transform.position)
        {
            Debug.Log("same Position");
        }
    }

    private void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Rohr"))
        {
            Debug.Log("Collision");

            other.gameObject.transform.position = gameObject.transform.position;
        }
    }
}

//Deactivate certain Scripts or components as soon as the object is set position.