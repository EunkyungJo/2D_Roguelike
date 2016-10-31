using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;
	public BoardManager boardScript;

	private int level = 3;

	//Awake is always called before any Start functions
	void Awake()
	{
		if (instance == null) 
		{
			instance = this;
		} 
		//If instance already exists and it's not this:
		else if (instance!=this)
		{
			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy (gameObject);
		}

		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad (gameObject);
		boardScript = GetComponent<BoardManager> ();
		InitGame ();
	}

	void InitGame()
	{
		//Call the SetupScene function of the BoardManager script, pass it current level number.
		boardScript.SetupScene (level);
	}

	void Update()
	{
	}
}