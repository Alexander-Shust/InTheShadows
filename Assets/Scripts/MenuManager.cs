using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartCampaign()
    {
        Settings.GameMode = GameMode.Campaign;
        PlayerPrefs.SetInt("1", 1);
        SceneManager.LoadScene("Campaign");
    }

    public void StartFreeChoice()
    {
        Settings.GameMode = GameMode.Test;
        SceneManager.LoadScene("Test");
    }

    public void ResetSave()
    {
        PlayerPrefs.DeleteAll();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
