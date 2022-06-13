using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _score;

    private void OnEnable() => 
        _player.ScoreAdded += OnScoreAdded;

    private void OnDisable() => 
        _player.ScoreAdded += OnScoreAdded;

    private void OnScoreAdded(int score)
    {
        _score.text = score.ToString();
    }
}
