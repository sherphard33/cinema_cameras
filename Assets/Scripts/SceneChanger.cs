using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public static SceneChanger Instance;
	private void Awake()
	{
		
			Instance = this;
	
	}

	public enum SceneName
	{
		MainMenu,
		Level01,
	}
	public void LoadScene(SceneName name)
	{
		SceneManager.LoadScene (name.ToString());
	}
	
	public void LoadNewGame()
	{
		SceneManager.LoadScene (SceneName.Level01.ToString());
	}

	public void LoadNextLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadMainMenu()
	{
		SceneManager.LoadScene (SceneName.MainMenu.ToString());
	}
	public void Exit()
	{
		Application.Quit ();
	}
}