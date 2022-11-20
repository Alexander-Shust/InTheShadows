using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    [SerializeField]
    private int _taskNumber;

    [SerializeField]
    private Button _startButton;

    private void Awake()
    {
        _startButton.onClick.AddListener(StartMission);
    }

    private void OnDestroy()
    {
        _startButton.onClick.RemoveListener(StartMission);
    }

    private void StartMission()
    {
        SceneManager.LoadScene(_taskNumber + 2);
    }
}