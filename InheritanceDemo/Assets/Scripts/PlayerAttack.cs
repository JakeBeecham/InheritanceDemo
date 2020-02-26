using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Weapon activeWeapon;
    public Transform AttachPoint;

	void Start ()
    {
        activeWeapon = Instantiate(activeWeapon, transform);
        activeWeapon.transform.position = AttachPoint.position;
	}
	
	void Update ()
    {
        //if activeWeapon is not null (has the weapon prefab been cloned)
        if (activeWeapon)
        {
            if (activeWeapon.IsAutomatic)
            {
                if (Input.GetButton("Fire1"))//left mouse button and right controller trigger
                {
                    if (activeWeapon.HasAmmo())
                        activeWeapon.Fire(AttachPoint.position);
                }
            }
            else
            {
                if (Input.GetButtonDown("Fire1"))//left mouse button and right controller trigger
                {
                    if (activeWeapon.HasAmmo())
                        activeWeapon.Fire(AttachPoint.position);
                }
            }
        }
	}
}
