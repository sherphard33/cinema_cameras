using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    [SerializeField] private Button _exitGameButton; 
    // Start is called before the first frame update
    void Start()
    {
        _exitGameButton.onClick.AddListener(ExitGameNow);
    }

    private void ExitGameNow()
    {
        SceneChanger.Instance.Exit();
        Debug.Log("Exit Game");
    }
}
