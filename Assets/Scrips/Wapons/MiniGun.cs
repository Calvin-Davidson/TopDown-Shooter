using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGun : Weapon
{
    private bool ShootReady;
    private Transform shootPoint;

    public MiniGun()
    {
        shootPoint = GameObject.Find("shootPoint").GetComponent<Transform>();
    }
    public override void UseWeapon()
    {
        if (ShootReady)
        {
            ShootReady = false;
            GameObject bulletObject = Instantiate(bullet, shootPoint.position, transform.rotation);
            bulletObject.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, 40));

            Destroy(bulletObject, 6f);

            StartCoroutine(MiniGunShootReady());
        }
    }

    public IEnumerator MiniGunShootReady()
    {
        yield return new WaitForSeconds(0.2f);
        ShootReady = true;
    }
}

