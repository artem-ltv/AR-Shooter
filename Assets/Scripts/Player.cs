using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public event UnityAction<int> ScoreAdded;

    private int _score;

    public void AddScore()
    {
        _score++;
        ScoreAdded?.Invoke(_score);
    }
}
