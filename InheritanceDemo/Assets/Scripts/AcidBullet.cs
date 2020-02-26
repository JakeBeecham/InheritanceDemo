using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidBullet : Bullet
{
    public GameObject AcidExplosionPrefab;

    private void CreateAcidExplosion()
    {
        Instantiate(AcidExplosionPrefab, transform.position, Quaternion.identity);
    }

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        CreateAcidExplosion();
        base.OnCollisionEnter2D(collision);
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        CreateAcidExplosion();
        base.OnTriggerEnter2D(collision);
    }
}
