using UnityEngine;
using System;
using System.Collections;
public class Weapon : MonoBehaviour {
    public int ammoToUse;
    private bool ShootReady = true;
    private Transform shootPoint;
    public GameObject bullet;

    private void Start()
    {
        shootPoint = GameObject.Find("shootPoint").GetComponent<Transform>();
    }

    public virtual void UseWeapon()
    {
        if (ShootReady)
        {
            ShootReady = false;
            GameObject bulletObject = Instantiate(bullet, shootPoint.position, transform.rotation);
            bulletObject.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, 20));

            Destroy(bulletObject, 5f);

            StartCoroutine(ShootReadyTimer());
        }
    }

    public IEnumerator ShootReadyTimer()
    {
        yield return new WaitForSeconds(0.9f);
        ShootReady = true;
    }
}