using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class sectionTrigger : MonoBehaviour
{
    public GameObject platformSection;
    public GameObject player;

    private void OnTriggerEnter2D()
    {    
        Debug.Log("ASHHHHH");

        Instantiate(platformSection, new Vector3(0, 13, 0), Quaternion.identity);
    }
}
