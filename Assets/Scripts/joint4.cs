﻿using UnityEngine;
using System.Collections;

public class joint4 : MonoBehaviour {

    public float J4 = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

      
    }

    void Add()
    {
        J4 = J4 + 1;
    }
    void Minus()
    {
        J4 = J4 - 1;
    }

  public  void SetJ(object val)
    {
        J4 = (float)System.Convert.ToDouble(string.Format("{0}", val));
		transform.localRotation = Quaternion.Euler(0, 90-J4, 90);
    }
}
