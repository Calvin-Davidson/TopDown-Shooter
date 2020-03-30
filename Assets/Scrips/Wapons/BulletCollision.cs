using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour 
{ 
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);

        EnemyManager enemyM = collision.collider.gameObject.GetComponent<EnemyManager>();
        if (enemyM != null)
        {
            enemyM.healtSystem.setHP(enemyM.healtSystem.getHP() - 25);
        }
    }
}
