using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject wallPrefab;
    public TextMeshProUGUI scoreLabel;

    public float spawnTerm = 4f;
    private float spawnTimer;

    public float score;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        spawnTimer = 0;
        score = 0;
    }

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        score += Time.deltaTime;
        scoreLabel.text = ((int)score).ToString();

        if (spawnTimer > spawnTerm)
        {
            spawnTimer -= spawnTerm;

            GameObject obj = Instantiate(wallPrefab);
            obj.transform.position = new Vector2(10f, Random.Range(-2.5f, 2.5f));
        }
    }
}
