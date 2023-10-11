using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class IntroManager : MonoBehaviour
{
    [SerializeField] private GameObject gameCam;
    [SerializeField] private GameObject menuCam;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject introCanvas;

    public void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        player.SetActive(false);
    }
    public void GameStart()
    {
        gameCam.SetActive(true);
        menuCam.SetActive(false);
        player.SetActive(true);
        introCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}