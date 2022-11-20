using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartCampaign()
    {
        Settings.GameMode = GameMode.Campaign;
        SceneManager.LoadScene("Campaign");
    }

    public void StartFreeChoice()
    {
        Settings.GameMode = GameMode.Test;
        SceneManager.LoadScene("Test");
    }
}
