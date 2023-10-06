using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float _score;

    private bool _hasWon;
    private bool _hasLost;

    public TMP_Text scoreText;
    public TMP_Text winText;
    public TMP_Text loseText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _score = GameObject.FindGameObjectsWithTag("Brick").Length;
        scoreText.text = "Bricks Left: " + _score;

        if (_score <= 0)
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0; // Pause game on winning
        }
    }

    public void LoseGame()
    {
        loseText.gameObject.SetActive(true);
        Time.timeScale = 0; // Pause game on losing

    }

}
