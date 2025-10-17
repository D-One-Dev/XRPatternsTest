using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private EnemySpawner spawner;

    private InputSystem_Actions _actions;

    private void Awake()
    {
        _actions = new InputSystem_Actions();
        _actions.Player.Space.performed += ctx => Attack();
    }

    void OnEnable()
    {
        _actions.Enable();
    }

    void OnDisable()
    {
        _actions.Disable();
    }
    private void Attack()
    {
        Debug.Log("Player Attacks");
        foreach (var enemy in FindObjectsByType<BasicEnemy>(FindObjectsSortMode.None))
            enemy.TakeDamage(50);
    }
}
