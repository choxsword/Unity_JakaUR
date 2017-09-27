using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	
	public float near = 20.0f;
	public float far = 100.0f;
	
	public float sensitivityX = 10f;
	public float sensitivityY = 10f;
	public float sensitivetyZ = 2f;
	public float sensitivetyMove = 2f;
	public float sensitivetyMouseWheel = 20f;

	public Transform target;
	
	GameObject RefCoor;
	Vector3 tempPosition ;



	void Start()
	{target=GameObject.Find("Robot").transform;
		GameObject Frame = GameObject.Find("Frame");
		RefCoor= Instantiate(Frame);
		RefCoor.SetActive(true);
		RefCoor.transform.localScale=new Vector3(1,1,1);
		RefCoor.transform.parent=GameObject.Find("Robot").transform;
		RefCoor.transform.rotation=Quaternion.identity;
		UpdateCoor();
		RefCoor.transform.localEulerAngles=new Vector3(0,180,0);
	}
	void Update () 
	{

		if (Input.GetAxis("Mouse ScrollWheel") != 0)
		{
//			this.GetComponent<Camera>().fieldOfView =this.GetComponent<Camera>().fieldOfView - Input.GetAxis("Mouse ScrollWheel")*sensitivetyMouseWheel;
//			this.GetComponent<Camera>().fieldOfView = Mathf.Clamp(this.GetComponent<Camera>().fieldOfView, near, far);

				if (Input.GetAxis("Mouse ScrollWheel") > 0)
					transform.Translate(Vector3.forward*0.5f);

				if (Input.GetAxis("Mouse ScrollWheel") < 0)
					transform.Translate(Vector3.forward*-0.5f);
			return;
		}


		if (Input.GetMouseButton(0))
		{transform.Translate(Vector3.right*-Input.GetAxis("Mouse X"));
	
			return;
		}
	

//		if (Input.GetMouseButton(1))
//		{ 
//			float rotationX = Input.GetAxis("Mouse X") * sensitivityX;
//			float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
//			transform.Rotate(-rotationY, rotationX, 0);            
//		}
		if(Input.GetMouseButton(2))
		{
//		transform.Rotate(Vector3.up * -Input.GetAxis("Mouse X")*4, Space.World); 
//			transform.Rotate(Vector3.forward * Input.GetAxis("Mouse Y")*2, Space.World); 


		transform.RotateAround(target.transform.position,Vector3.up,Input.GetAxis("Mouse X")*5);
			transform.RotateAround(target.transform.position,transform.right,-Input.GetAxis("Mouse Y")*5);
			return;
		}


	}

	private void UpdateCoor()
	{
		
		tempPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2,0));  
		//RefCoor.transform.position = new Vector3(tempPosition.x-6,tempPosition.y-3,tempPosition.z-5);
		
		
	}
}