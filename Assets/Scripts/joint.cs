using UnityEngine;
using System.Collections;

public class joint : MonoBehaviour
{
	public float J;

	public GameObject Points;

	public virtual void SetJ(object val)
	{}
	public void draw()
	{
		GameObject.Find("Points").GetComponent<Points>().Draw();
	}
}

