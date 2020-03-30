using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    private GameObject _player;
    private PlayerManager _playerManager;
    private HealthRenderer _HealthRenderer;

    [SerializeField] private int AttackDamage = 0;
    [SerializeField] private float AttackDelay = 0;
    private void Start()
    {
        _player = GameObject.Find("Player");
        _playerManager = _player.GetComponent<PlayerManager>();
        _HealthRenderer = GameObject.Find("Canvas").GetComponent<HealthRenderer>();

        StartCoroutine(Attack(2));
    }

    public IEnumerator Attack(float Waitfor)
    {
        yield return new WaitForSeconds(Waitfor);
        Vector3 playerPos = _player.transform.position;
        if (Vector3.Distance(playerPos, transform.position) < 1.3)
        {
            _playerManager.playerData.healtSystem.removeHealth(AttackDamage);
            _HealthRenderer.UpdateHealtBar();
            StartCoroutine(Attack(AttackDelay));
        } else
        {
            StartCoroutine(Attack(0.3f));
        }
    }
}
