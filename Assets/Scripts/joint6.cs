﻿using UnityEngine;
using System.Collections;

public class joint6 : MonoBehaviour {

    public float J6 = 0;
    // Use this for initialization
    void Start()
    {
	
    }

    // Update is called once per frame
    void Update()
    {
        //Add();
//		J6+=0.1f;
//		transform.localRotation =   Quaternion.Euler(0,-J6,0);

    }

    void Add()
    {
        J6 = J6 + 1;
    }
    void Minus()
    {
        J6 = J6 - 1;
    }

   public  void SetJ(object val)
    {
        J6 = (float)System.Convert.ToDouble(string.Format("{0}", val));
		transform.localRotation = Quaternion.Euler(0,-J6,0);
    }
}
