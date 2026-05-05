using UnityEngine;
using TMPro;

public class ScoringManager : MonoBehaviour
{
    public float maxYLevel;
    public GameObject player;

    public TextMeshProUGUI scoreText;
    public float score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y > maxYLevel) 
        { 
            maxYLevel = player.transform.position.y;
        }

        score = Mathf.Ceil(maxYLevel);
        scoreText.text = score.ToString();
    }
}
