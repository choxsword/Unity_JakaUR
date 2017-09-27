using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour
{
	GameObject toolCenter;
	// Use this for initialization



	joint J1,J2,J3,J4,J5,J6;
	void Start ()
	{
		J1=GameObject.Find("Axis1").GetComponent<joint1>();
		J2=  GameObject.Find("Axis2").GetComponent<joint2>();
		J3=  GameObject.Find("Axis3").GetComponent<joint3>();
		J4=GameObject.Find("Axis4").GetComponent<joint4>();
		J5=GameObject.Find("Axis5").GetComponent<joint5>();
		J6=GameObject.Find("Axis6").GetComponent<joint6>();

		UpdateJoints("0"+" "+"90"+" "+"-90"+" "+"90"+" "+"90"+" "+"0");
	}
	


	void UpdateJoints(string MsgFromWinForm)
	
	{
		string[] JointValue=MsgFromWinForm.Split(' ');
 
		J1.SetJ(JointValue[0]);
	 J2.SetJ(JointValue[1]);
J3.SetJ(JointValue[2]);
		J4.SetJ(JointValue[3]);
		J5.SetJ(JointValue[4]);
		J6.SetJ(JointValue[5]);


	}




}

