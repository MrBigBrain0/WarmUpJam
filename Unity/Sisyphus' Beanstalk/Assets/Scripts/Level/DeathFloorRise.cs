using UnityEngine;

public class DeathFloorRise : MonoBehaviour
{
    public Transform transform;
    Vector3 yLevel;
    public GameObject player;

    public float risingSpeed;
    bool rise;
    void Start()
    {
        transform = GetComponent<Transform>();
        yLevel = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y >= 7)
        {
            rise = true;
        }

        if (rise)
        {
            yLevel.y += risingSpeed;
        }

        transform.position = yLevel;
    }
}
