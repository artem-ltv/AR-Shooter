using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _minSpawnRadius;
    [SerializeField] private float _maxSpawnRadius;
    [SerializeField] private float _secondBetweenSpawn;
    [SerializeField] private Enemy[] _enemies;

    private void Start()
    {
        StartCoroutine(SpawnRandomEnemy());
    }

    private IEnumerator SpawnRandomEnemy()
    {
        while (true)
        {
            float spawnRadius = Random.Range(_minSpawnRadius, _maxSpawnRadius);
            Enemy newEnemy = Instantiate(_enemies[Random.Range(0, _enemies.Length)], GetRandomSphere(spawnRadius), Quaternion.identity);
            newEnemy.EnemyDie += OnEnemyDying;
            Vector3 lookDirection = _player.transform.position - newEnemy.transform.position;
            newEnemy.transform.rotation = Quaternion.LookRotation(lookDirection);

            yield return new WaitForSeconds(_secondBetweenSpawn);
        }
    }

    private void OnEnemyDying(Enemy enemy)
    {
        enemy.EnemyDie -= OnEnemyDying;
        _player.AddScore();
    }

    private Vector3 GetRandomSphere(float radius)
    {
        return Random.insideUnitSphere * radius;
    }
}
