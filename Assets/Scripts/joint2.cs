using UnityEngine;
using System.Collections;

public class joint2 : MonoBehaviour {

    public float J2 = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Add();

    
	}

    void Add()
    {
        J2 = J2 + 1;
    }
    void Minus()
    {
        J2 = J2 - 1;
    }

   public void SetJ(object val)
    {
        J2 = (float)System.Convert.ToDouble(string.Format("{0}", val));
		transform.localRotation = Quaternion.Euler(0, 180-J2, 0);
    }
}
