using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour
{
	GameObject toolCenter;
	// Use this for initialization
	void Start ()
	{
		//toolCenter=GameObject.Find("toolFrame");
		UpdateJoints("0"+" "+"90"+" "+"-90"+" "+"90"+" "+"90"+" "+"0");
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Debug.Log(toolCenter.transform.position.ToString());\
	}

	void UpdateJoints(string MsgFromWinForm)
	
	{
		string[] JointValue=MsgFromWinForm.Split(' ');
		//Application.ExternalCall("msg",JointValue);  
		GameObject.Find("Axis1").GetComponent<joint1>().SetJ(JointValue[0]);
	  GameObject.Find("Axis2").GetComponent<joint2>().SetJ(JointValue[1]);
	  GameObject.Find("Axis3").GetComponent<joint3>().SetJ(JointValue[2]);
		GameObject.Find("Axis4").GetComponent<joint4>().SetJ(JointValue[3]);
		GameObject.Find("Axis5").GetComponent<joint5>().SetJ(JointValue[4]);
		GameObject.Find("Axis6").GetComponent<joint6>().SetJ(JointValue[5]);


	}




}

