using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class sectionTrigger : MonoBehaviour
{
    public Transform platformSection;
    public Transform platformTriggerSpawn;
    public Transform spawnPlatformPosition;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the player reaches this trigger is spawns the next platform prefab above before the player can see it

        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(platformSection, spawnPlatformPosition.transform.position, Quaternion.identity);

        }
        
        
    }

}
