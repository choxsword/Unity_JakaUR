using UnityEngine;
using System.Collections;

public class DisplayAndHide : MonoBehaviour {

    GameObject worldFrame;
    GameObject customFrame;
    GameObject toolFrame;
    string[] transformPara;
	float[] CenterPos=new float[6];
	GameObject OriginTool;


	// Use this for initialization
	void Start () {
           worldFrame = GameObject.Find("Frame");
		customFrame = Instantiate(worldFrame,worldFrame.transform.position,worldFrame.transform.rotation) as GameObject;
		customFrame.transform.localScale=new Vector3(1,1,1);
           toolFrame = GameObject.Find("toolFrame");
			OriginTool= Instantiate(toolFrame,toolFrame.transform.position,toolFrame.transform.rotation) as GameObject;


		OriginTool.transform.parent=GameObject.Find("Axis6").transform;
		OriginTool.transform.localScale=new Vector3(1,1,1);

         //  HideWorld();
	HideOriginTool();
		HideCustom();


	}
	

	void ChangeSkyBox()
	{
		RenderSettings.skybox=(Material)Resources.Load("sky5X2",typeof(Material));
		Debug.Log("shit");
	}

	void HideOriginTool()
	{
		OriginTool.SetActive(false);


	}
	void DispOriginTool()
	{
		OriginTool.SetActive(true);

	}

    void HideWorld()
    {
       
        worldFrame.SetActive(false);

    }

    void DisplayWorld()
    {
       
        worldFrame.SetActive(true);

    }

    void HideTool()
    {

        toolFrame.SetActive(false);

    }

    void DisplayTool()
    {

        toolFrame.SetActive(true);

    }

    void HideCustom()
    {

        customFrame.SetActive(false);

    }

    void DisplayCustom()
    {

        customFrame.SetActive(true);

    }


    void TransformToolFrame(string val)
    {
		string[] ToolCenter=val.Split(' ');
		for(int i=0;i<3;i++)
		{CenterPos[i]=0.01f*(float)System.Convert.ToDouble(ToolCenter[i]);
		}
		for(int i=3;i<6;i++)
		{CenterPos[i]=(float)System.Convert.ToDouble(ToolCenter[i]);
		}


        toolFrame.SetActive(true);

		toolFrame.transform.localPosition=new Vector3(0f,0.873f,0f);
		toolFrame.transform.localEulerAngles=new Vector3(0,90,0);

        toolFrame.transform.Translate(new Vector3(CenterPos[1],CenterPos[2], -CenterPos[0]), Space.Self);
		toolFrame.transform.Rotate(Vector3.up * -CenterPos[3], Space.Self);
		toolFrame.transform.Rotate(Vector3.right * -CenterPos[4], Space.Self);
		toolFrame.transform.Rotate(Vector3.forward * CenterPos[5], Space.Self);

    }

    void TransformCustomFrame(object val)
    {
        string s = (string)val;
        customFrame.SetActive(true);
        transformPara = s.Split(new char[] { ' ' });
        //foreach(string temp in transformPara)
        //    Debug.Log(temp);
		customFrame.transform.position=new Vector3(0,0,0);
		customFrame.transform.localEulerAngles=new Vector3(0,180,0);
        customFrame.transform.Translate( float.Parse(transformPara[1]) * 0.01f, float.Parse(transformPara[2]) * 0.01f, -float.Parse(transformPara[0]) * 0.01f,Space.Self);

        customFrame.transform.Rotate(Vector3.up * -float.Parse(transformPara[3]), Space.Self);
        customFrame.transform.Rotate(Vector3.right * -float.Parse(transformPara[4]), Space.Self);
        customFrame.transform.Rotate(Vector3.forward * float.Parse(transformPara[5]), Space.Self);


    }

	    void deleteCustom()
	    {
	

	        customFrame.SetActive(false);
	
	
	
	    }
}
