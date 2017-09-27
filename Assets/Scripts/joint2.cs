using UnityEngine;
using System.Collections;

public class joint2 : joint {


	public override void SetJ(object val)
    {
        J= (float)System.Convert.ToDouble(string.Format("{0}", val));
		transform.localRotation = Quaternion.Euler(0, 180-J, 0);
    }
}
