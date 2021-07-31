using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletTempLate;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bulletTempLate, _shootPoint);
        }

        //if(Input.GetTouch(0).phase == TouchPhase.Began(0))
        //{
        //    Instantiate(_bulletTempLate, _shootPoint);
        //}
    }
}
