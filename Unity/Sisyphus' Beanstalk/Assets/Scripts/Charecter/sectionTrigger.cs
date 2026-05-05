using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class sectionTrigger : MonoBehaviour
{
   
    [SerializeField] private Transform levelSectionStart;
    [SerializeField] private Transform levelSection;

    private void Awake()
    {
// to spawn the next section
        Transform lastLevelSectionTransform;
        lastLevelSectionTransform = SpawnLevelSection(levelSectionStart.Find("EndPosition").position);
        lastLevelSectionTransform = SpawnLevelSection(lastLevelSectionTransform.Find("EndPosition").position);
        lastLevelSectionTransform = SpawnLevelSection(lastLevelSectionTransform.Find("EndPosition").position);
        lastLevelSectionTransform = SpawnLevelSection(lastLevelSectionTransform.Find("EndPosition").position);
        lastLevelSectionTransform = SpawnLevelSection(lastLevelSectionTransform.Find("EndPosition").position);
        lastLevelSectionTransform = SpawnLevelSection(lastLevelSectionTransform.Find("EndPosition").position);

    }
    
    private Transform SpawnLevelSection(Vector3 spawnPosition)
    {
        // Instantiates the sections to spawn, spawnPosition is set in the method: Awake
        Transform levelPartTransform = Instantiate(levelSection, spawnPosition, Quaternion.identity);
        return levelPartTransform;
       
       
    }

}
