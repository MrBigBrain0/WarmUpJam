using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class sectionTrigger : MonoBehaviour
{
    public Transform platformSection;
    public Transform platformTriggerSpawn;
    public Transform triggerSpawn;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        platformTriggerSpawn = Instantiate(platformSection, triggerSpawn.transform.position, Quaternion.identity);

    }
}
