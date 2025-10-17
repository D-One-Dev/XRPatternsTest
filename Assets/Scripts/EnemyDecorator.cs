using UnityEngine;

public abstract class EnemyDecorator : IEnemy
{
    protected IEnemy _wrappedEnemy;

    public EnemyDecorator(IEnemy enemy)
    {
        _wrappedEnemy = enemy;
    }

    public virtual void Spawn(Vector3 position)
    {
        _wrappedEnemy.Spawn(position);
    }

    public virtual void TakeDamage(int amount)
    {
        _wrappedEnemy.TakeDamage(amount);
    }
}
