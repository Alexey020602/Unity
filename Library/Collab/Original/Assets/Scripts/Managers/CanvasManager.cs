﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : SimpleSingleton<CanvasManager>
{
    [Header("Counters")]
    public Text CurrentCounter;
    public Text TheBestCounter;
    public CountDownTimer CountDownTimer;

    [Header("Player")]
    public Image StaminaBar;
    private PlayerManager Player;

    [Header("Menu")]
    public GameObject _RestartMenu;
    public GameObject _PauseMenu;
    public GameObject _ObstaclesMenu;

    public void UpdateCurrentCounter(float Counter)
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "MainMenu") return;
        CurrentCounter.text = "Счет:" + (int)Counter;
    }
    public void UpdateTheBestCounter(float counter)
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "MainMenu") return;
        TheBestCounter.text = "Лучший счет:" + (int)counter;
    }

    public void RestartMenu(bool active)
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "MainMenu") return;
        _RestartMenu.SetActive(active);
    }
    public void PauseMenu(bool active)
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "MainMenu") return;
        _PauseMenu.SetActive(active);
    }
    private void Awake()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "MainMenu") return;
        Player = PlayerManager.Instance;
    }
    private void Update()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "MainMenu") return;
        StaminaBar.fillAmount = Player.stamina;
    }



}
