using UnityEngine;
using System.Collections;

public class FPSCounter : MonoBehaviour
{
	string label = "";
	float count;


	void Awake()
	{
		QualitySettings.vSyncCount = 0;  // VSync must be disabled
		Application.targetFrameRate = 60;
	}


	IEnumerator Start()
	{
		GUI.depth = 2;
		while (true)
		{
			if (Time.timeScale == 1)
			{
				yield return new WaitForSeconds(0.1f);
				count = (1 / Time.deltaTime);
				label = "FPS :" + (Mathf.Round(count));
			}
			else
			{
				label = "Pause";
			}
			yield return new WaitForSeconds(0.5f);
		}
	}

	void OnGUI()
	{
		var guiStyle = new GUIStyle();
		guiStyle.fontSize = 30;
		GUI.Label(new Rect(25, 1000, 150, 50), label, guiStyle);
	}
}


