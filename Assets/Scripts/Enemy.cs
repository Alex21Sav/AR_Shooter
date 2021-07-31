using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ParticleSystem _deafEffect;

    public event UnityAction<Enemy> Dying;
     public void Dia()
    {
        Instantiate(_deafEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Dying?.Invoke(this);
    }

    
}
