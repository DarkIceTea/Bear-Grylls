using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private Button finishButton;
    // Start is called before the first frame update
    void Start()
    {
        finishButton.onClick.AddListener(finishPressed);
    }

    void OnDestroy()
    {
        finishButton.onClick.RemoveListener(finishPressed);
    }

    private void finishPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
