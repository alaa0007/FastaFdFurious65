﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//car controll scirpt

public class CarControll : MonoBehaviour 
{
    public float carHorizontalSpeed;
    public float maxDurability = 100f;
    public float durability;

    private Vector3 _carPosition;

    public void Start()
    {
        _carPosition = this.gameObject.transform.position;
        durability = 100f;
    }

    private void Update()
    {
        _carPosition.x += Input.GetAxis("Horizontal") * carHorizontalSpeed * Time.deltaTime;

        _carPosition.x = Mathf.Clamp(_carPosition.x, -2.40f, 2.40f);

        this.gameObject.transform.position = _carPosition;
    }
}
