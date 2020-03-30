using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private PlayerManager _playerManager;
    public HealtSystem healtSystem;
    [SerializeField] private int _StartHealth;
    private EnemiesKilled _EnemiesKilled;

    private void Start()
    {
        _playerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
        healtSystem = new HealtSystem(this.gameObject, _StartHealth);
        _EnemiesKilled = GameObject.Find("Canvas").GetComponent<EnemiesKilled>();

        healtSystem.EntityDieEvent += EnemyDie;
    }

    private void EnemyDie(GameObject obj)
    {
        _playerManager.playerData.addEnemiesKilled();
        Destroy(this.gameObject);
    }
}