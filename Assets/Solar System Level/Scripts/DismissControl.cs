using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DismissControl : MonoBehaviour
{
    [SerializeField]
    private GameObject welcomePanel;
    [SerializeField]
    private Button dismissButton;

    void Awake() 
    {
        dismissButton.onClick.AddListener(Dismiss);
    }
    private void Dismiss() => welcomePanel.SetActive(false);
}
