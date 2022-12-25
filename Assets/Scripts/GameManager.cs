using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private Button _restartButton;

    [SerializeField] private Button _nextLevelButton;
    [SerializeField] private TextMeshProUGUI _finalScoreText;
    [SerializeField] private GameObject _finishPanel;

    [SerializeField] private GameObject _losePanel;
    [SerializeField] private TextMeshProUGUI _loseText;
    [SerializeField] private Button _rebootButton;

    [SerializeField] private float _gameOverScreenShowTime;
    [SerializeField] private float _finishScreenShowTime;

    private int _score;
    public bool isGameActive = true;

    public void UpdateScore(int scoreToAdd)
    {
        _score += scoreToAdd;
        _scoreText.text = "Score: " + _score;
    }

     IEnumerator GameOver()
    {
        isGameActive = false;

        yield return new WaitForSeconds(_gameOverScreenShowTime);
        _losePanel.SetActive(true);
        _scoreText.gameObject.SetActive(false);
        _restartButton.gameObject.SetActive(false);
    }

    IEnumerator FinishLevel()
    {
        isGameActive = false;

        yield return new WaitForSeconds(_finishScreenShowTime);
        _finalScoreText.text = "Score:" + _score;
        _finishPanel.SetActive(true);
        _scoreText.gameObject.SetActive(false);
        _restartButton.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
