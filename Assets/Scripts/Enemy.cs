using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public event UnityAction<Enemy> EnemyDie;

    [SerializeField] private ParticleSystem _deathEffect;

    public void Die()
    {
        Instantiate(_deathEffect, this.transform.position, Quaternion.identity);
        EnemyDie?.Invoke(this);
        Destroy(gameObject);
    }
}
