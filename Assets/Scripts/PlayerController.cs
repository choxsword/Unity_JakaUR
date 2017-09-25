using UnityEngine;
using System.Collections;

using System.Collections.Generic;
public class PlayerController : MonoBehaviour {
	private Transform m_Transform;

	GameObject RefCoor;
	Vector3 tempPosition ;
	void Start () {

		GameObject Frame = GameObject.Find("Frame");
	RefCoor= Instantiate(Frame);
	RefCoor.SetActive(true);
	RefCoor.transform.localScale=new Vector3(1,1,1);
	RefCoor.transform.parent=GameObject.Find("Robot").transform;
		m_Transform = gameObject.GetComponent<Transform>();

		RefCoor.transform.rotation=Quaternion.identity;
		UpdateCoor();
		RefCoor.transform.localEulerAngles=new Vector3(0,180,0);
	}
	// Update is called once per frame
	void Update () {
		MoveControl();
	}
	void MoveControl()
	{

//		if (Input.GetKey(KeyCode.W))
//		{
//			m_Transform.Translate(Vector3.forward * 1f, Space.Self);
//
//			UpdateCoor();
//			return;
//		}
//		if (Input.GetKey(KeyCode.S))
//		{
//			m_Transform.Translate(Vector3.back * 1f, Space.Self);	UpdateCoor();return;
//		}
//		if (Input.GetKey(KeyCode.A))
//		{
//			m_Transform.Translate(Vector3.left * 1f, Space.Self);	UpdateCoor();return;
//		}
//		if (Input.GetKey(KeyCode.D))
//		{
//			m_Transform.Translate(Vector3.right * 1f, Space.Self);	UpdateCoor();return;
//		}
//		if (Input.GetKey(KeyCode.Q))
//		{
//			m_Transform.Rotate(Vector3.up, -1.0f);	UpdateCoor();return;
//		}
//		if (Input.GetKey(KeyCode.E))
//		{
//			m_Transform.Rotate(Vector3.up, 1.0f);	UpdateCoor();return;
//		}
//				if (Input.GetAxis("Mouse ScrollWheel") < 0)
//				{
//			m_Transform.Translate(Vector3.forward * 2f, Space.Self); UpdateCoor();return;
//				}
//				if (Input.GetAxis("Mouse ScrollWheel") > 0)
//				{
//			m_Transform.Translate(Vector3.back * 2f, Space.Self); UpdateCoor();return;
//				}
//		
		if(Input.GetMouseButton(2))
		{
			m_Transform.Rotate(Vector3.up * -Input.GetAxis("Mouse X")*4, Space.World); 
			m_Transform.Rotate(Vector3.forward * Input.GetAxis("Mouse Y")*2, Space.World); 
			//m_Transform.Rotate(Vector3.forward * Input.GetAxis("Mouse Y")*4, Space.Self); 
			UpdateCoor();
	
			return;
			
		}
		//m_Transform.Rotate(Vector3.up, Input.GetAxis("Mouse X"));
	//	m_Transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y"));
	}

	IEnumerator OnMouseDown()
	{
		Vector3 screenSpace = Camera.main.WorldToScreenPoint(transform.position);

		var offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));

		while (Input.GetMouseButton(0))
		{
			Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
			var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
			transform.position = curPosition;
			UpdateCoor();
			yield return new WaitForFixedUpdate();
		}


	}

	private void UpdateCoor()
	{
		
		tempPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width/2, Screen.height/2));  
		RefCoor.transform.position = new Vector3(tempPosition.x-6,tempPosition.y-3,tempPosition.z-5);

		
	}
}

