using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour
{

	private LineRenderer lineRenderer;
	private Vector3 position;
	public GameObject Tool;
	private int index = 1;//不包括起点
	public ArrayList Drawpoints = new ArrayList ();
	public bool drawit;

	private float distance=0;

	string option = "";
	private GameObject P;
	private Vector3 EndPoint=new Vector3();
	private Vector3 LastPoint=new Vector3();
	void Start ()
	{

		lineRenderer = GameObject.Find ("Points").GetComponent<LineRenderer> ();

		//lineRenderer.material = new Material (Shader.Find ("Particles/Additive"));

		lineRenderer.SetColors (Color.red, Color.green);

		lineRenderer.SetWidth (0.02f, 0.02f);
		Tool = GameObject.Find ("toolFrame");
		P = GameObject.Find ("Points");
		drawit=false;
		//P.SetActive(false);
	}

	void Update ()
	{
		if (drawit) {
		
			if (!EndPoint.Equals(LastPoint)) {

				lineRenderer.SetVertexCount (index+1);

			distance += (LastPoint-EndPoint).magnitude;
				lineRenderer.SetPosition (index,EndPoint);
				LastPoint=EndPoint;
				++index;
			
			}

		}
	}

	public void SetDrawState (object opt)
	{
		option = opt.ToString ();
		if (option == "y") {
			drawit = true;
			Draw();
			LastPoint=EndPoint;
			lineRenderer.SetVertexCount (1);
			lineRenderer.SetPosition (0,LastPoint);
			//P.SetActive(true);
		}
		else {
			drawit = false;
			Drawpoints.Clear ();
			index=0;
			lineRenderer.SetVertexCount (0);
			distance=0;
			//P.SetActive(false);
		}

	}

	public void Draw ()
	{
	
		if (drawit) {

			EndPoint.x = Tool.transform.position.x;
			EndPoint.y = Tool.transform.position.y;
			EndPoint.z = Tool.transform.position.z;
			//Drawpoints.Add (EndPoint);
		}

	}

	void OnGUI ()
	{
		if(drawit)
		{
		GUILayout.Label ("当前路径长度：" + 100*distance+"mm");
		}
	}
}