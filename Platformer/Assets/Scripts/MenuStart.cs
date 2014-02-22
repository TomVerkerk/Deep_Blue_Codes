using UnityEngine;
using System.Collections;

public class MenuStart: MonoBehaviour {
	
	public Texture2D cursorTexture;
	//private CursorMode cursormodee;
	//private Vector2 hotSpot;
	public AudioClip background;
	
	void Start ()
	{
		//cursormodee = CursorMode.Auto;
		//hotSpot = Vector2.zero;
		audio.PlayOneShot(background);
	}
	
	void OnGUI() 
	{
		GUI.backgroundColor = Color.blue;
		

			
		if(GUI.Button(new Rect(35,410,200,80),""))
		{
			Application.LoadLevel("level1webplayer");
		}
		if(GUI.Button(new Rect(350,400,365,110),""))
		{
			Application.LoadLevel ("Options");
		}
		if(GUI.Button(new Rect(888,522,345,100),""))
		{
			Application.LoadLevel("Credits");
		}
		if(GUI.Button(new Rect(1056,110,200,40),""))
		{
			Application.LoadLevel ("Controls");
		}
		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();	
		}
	}
	void OnMouseEnter()
	{
		//Cursor.SetCursor(cursorTexture, hotSpot, cursormodee);
		Debug.Log(":O");	
	}
	
	void OnMouseExit ()
	{
		//Cursor.SetCursor(null, Vector2.zero, cursormodee);	
	}
}
