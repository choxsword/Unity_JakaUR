using UnityEngine;
using System.Collections;

public class joint5 : joint {


	public override void SetJ(object val)
    {
        J = (float)System.Convert.ToDouble(string.Format("{0}", val));
		transform.localRotation = Quaternion.Euler(0, 0, -J);
    }
}
