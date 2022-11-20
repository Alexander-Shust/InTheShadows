using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    [SerializeField]
    private int _taskNumber;

    [SerializeField]
    private Button _startButton;

    [SerializeField]
    private Image _lock;

    [SerializeField]
    private Image _unlock;

    private void Awake()
    {
        _startButton.onClick.AddListener(StartMission);
    }

    private void OnEnable()
    {
        if (Settings.GameMode == GameMode.Campaign
            && PlayerPrefs.GetInt(_taskNumber.ToString()) == 0)
        {
            _lock.gameObject.SetActive(true);
            _unlock.gameObject.SetActive(false);
        }
        else
        {
            _lock.gameObject.SetActive(false);
            _unlock.gameObject.SetActive(true);
        }
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