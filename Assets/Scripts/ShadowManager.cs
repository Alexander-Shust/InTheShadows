using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShadowManager : MonoBehaviour
{
    [SerializeField]
    private Button _backButton;

    [SerializeField]
    private TMP_Text _timer;

    [SerializeField]
    private TMP_Text _victory;

    private float _time;
    private bool _isTicking;
    
    private void Awake()
    {
        _victory.gameObject.SetActive(false);
        _backButton.onClick.AddListener(ReturnToMenu);
        _time = 0.0f;
        _isTicking = true;
    }

    private void Update()
    {
        if (!_isTicking) return;
        
        var deltaTime = Time.deltaTime;
        _time += deltaTime;
        _timer.text = _time.ToString("F0");
        CheckVictory();
    }

    private void CheckVictory()
    {
        if (_time >= 5.0f)
        {
            _isTicking = false;
            _victory.gameObject.SetActive(true);
        }
    }

    private void OnDestroy()
    {
        _backButton.onClick.RemoveListener(ReturnToMenu);
    }

    private void ReturnToMenu()
    {
        SceneManager.LoadScene(Settings.GameMode == GameMode.Campaign ? "Campaign" : "Test");
    }
}