using UnityEngine;
using System.Collections;

public class joint1 : joint {

	public override void SetJ(object val) {
        J = (float)System.Convert.ToDouble(string.Format("{0}", val));
		transform.localEulerAngles=(new Vector3(0,270,270+J));
    }
}
