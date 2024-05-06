using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject Pipes;

    public GameOverBehaviour GameOverScreen;

    public float TimeToSpawn = 2;

    private float _time = 0;
    public float height;

    private int _score = 0;

    public TMP_Text ScoreText;

    public GameObject Bird;

    private bool _gameOver = false;

    private void Awake()
    {
        // Si jamais on charge une 2e scene
        // avec un autre GameManager
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!_gameOver && _time > TimeToSpawn)
        {
            GameObject pipe = Instantiate(Pipes);
            pipe.transform.position = transform.position + new Vector3(0.5f, Random.Range(-height, height), 0);

            _time = 0;

            Destroy(pipe, 10);
        }

        _time += Time.deltaTime;
    }

    public void AddScore(int score)
    {
        _score += score;
        ScoreText.text = $"{_score}";
    }

    public void GameOver()
    {
        GameOverScreen.Setup(_score);
        _gameOver = true;
        Destroy(Bird);
    }
}
