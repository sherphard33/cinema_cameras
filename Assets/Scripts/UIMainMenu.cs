using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    // Start is called before the first frame update
    void Start()
    {   _startButton.onClick.AddListener(StartGame);
        
    }

  private void StartGame()
  {
    SceneChanger.Instance.LoadNewGame();
      Debug.Log("Start Game");
  }
}
