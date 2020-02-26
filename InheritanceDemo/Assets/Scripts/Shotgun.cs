using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    public override void Fire(Vector3 fireFromPosition)
    {
        Shoot(fireFromPosition, transform.up);
        Shoot(fireFromPosition, transform.up + new Vector3(0.1f, 0, 0));
        Shoot(fireFromPosition, transform.up - new Vector3(0.1f, 0, 0));

        base.Fire(fireFromPosition);
    }

    private void Shoot(Vector3 position, Vector3 direction)
    {
        //create a clone of the bullet prefab
        GameObject projectile = Instantiate(BulletPrefab, position, Quaternion.identity);

        Bullet bullet = projectile.GetComponent<Bullet>();
        //fire the bullet in the direction the gun is facing
        bullet.SetDirection(direction);
    }
}
