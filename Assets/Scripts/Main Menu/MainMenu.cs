﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject defaultButton;
    EventSystem m_EventSystem;
    // Start is called before the first frame update

    void OnEnable()
    {
        //Fetch the current EventSystem. Make sure your Scene has one.
        m_EventSystem = EventSystem.current;
        if (defaultButton != null)
        {
            m_EventSystem.SetSelectedGameObject(defaultButton, null);
        }
    }
    public void loadGame()
    {
        SceneManager.LoadScene("Game");
    }
}
