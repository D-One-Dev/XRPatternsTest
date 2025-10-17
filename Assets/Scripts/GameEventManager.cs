using System;

public class GameEventManager
{
    private static GameEventManager _instance;
    public static GameEventManager Instance => _instance ??= new GameEventManager();

    public event Action<IEnemy> OnEnemyDestroyed;

    public void NotifyEnemyDestroyed(IEnemy enemy)
    {
        OnEnemyDestroyed?.Invoke(enemy);
    }
}
