using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeExplode : MonoBehaviour
{
    public GameObject Particle;
    void Start()
    {
        StartCoroutine(explode());
    }

    public IEnumerator explode()
    {
        yield return new WaitForSeconds(3);

        GameObject Spawnedparticle = Instantiate(Particle, this.transform.position, Quaternion.identity);
        
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 4f);
        foreach (Collider collider in hitColliders)
        {
            EnemyManager manager = collider.gameObject.GetComponent<EnemyManager>();
            if (manager != null)
            {
                if (manager.healtSystem != null)
                {
                    manager.healtSystem.setHP(manager.healtSystem.getHP() - 50);
                }
            }
        }

        Destroy(Spawnedparticle, 2.5f);

        Destroy(this.gameObject);
    }
}
