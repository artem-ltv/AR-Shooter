using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ParticleSystem _deathEffect;

    public void Die()
    {
        Instantiate(_deathEffect, this.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
