﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotator : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 20, 30) * Time.deltaTime);
    }
}
