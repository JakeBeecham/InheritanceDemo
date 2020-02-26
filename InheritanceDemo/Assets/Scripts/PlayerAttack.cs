using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Weapon activeWeapon;

	void Start ()
    {
        activeWeapon = Instantiate(activeWeapon, transform);
        activeWeapon.transform.position = transform.position;
	}
	
	void Update ()
    {
        //if activeWeapon is not null (has the weapon prefab been cloned)
        if (activeWeapon)
        {
            if (activeWeapon.IsAutomatic)
            {
                if (Input.GetButtonDown("Fire1"))//left mouse button and right controller trigger
                {
                    if (activeWeapon.HasAmmo())
                        activeWeapon.Fire(transform.position);
                }
            }
            else
            {
                if (Input.GetButtonDown("Fire1"))//left mouse button and right controller trigger
                {
                    if (activeWeapon.HasAmmo())
                        activeWeapon.Fire(transform.position);
                }
            }
        }
	}
}
