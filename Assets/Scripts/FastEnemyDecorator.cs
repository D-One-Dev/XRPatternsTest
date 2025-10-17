using UnityEngine;

public class FastEnemyDecorator : EnemyDecorator
{
    private float speedMultiplier = 1.5f;

    public FastEnemyDecorator(IEnemy enemy) : base(enemy) { }

    public override void Spawn(Vector3 position)
    {
        base.Spawn(position);
        Debug.Log($"Enemy speed boosted by ×{speedMultiplier} times.");
        var go = (_wrappedEnemy as MonoBehaviour).gameObject;
        go.GetComponent<Rigidbody>().linearVelocity = Vector3.forward * speedMultiplier;
    }
}
