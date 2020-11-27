﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionReaction : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 20.0F;

    void Start()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
        }
    }
}
