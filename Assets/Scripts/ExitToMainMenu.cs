using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitToMainMenu : MonoBehaviour
{
    [SerializeField] private Button _exitButton; 
    // Start is called before the first frame update
    void Start()
    {
        _exitButton.onClick.AddListener(ExitToMain);
    }

    private void ExitToMain()
    {
        SceneChanger.Instance.LoadMainMenu();
        Debug.Log("Exit to Main Menu");
    }

}
