﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public Transform muzzle;
    public Projectile projectile;
    public float rateOfFire = 100;
    public float muzzleVelocity;

    float nextShot;

    public void Shoot()
    {
        if (Time.time > nextShot)
        {
            nextShot = Time.time + rateOfFire / 1000;
            Projectile newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
            newProjectile.SetSpeed(muzzleVelocity);
        }
    }
}
