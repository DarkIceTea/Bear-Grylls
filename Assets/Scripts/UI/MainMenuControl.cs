using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField] private Button playButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayPressed);
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveListener(PlayPressed);
    }

    private void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }
}
