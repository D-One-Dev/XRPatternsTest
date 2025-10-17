using UnityEngine;

public interface IEnemy
{
    void Spawn(Vector3 position);
    void TakeDamage(int amount);
}