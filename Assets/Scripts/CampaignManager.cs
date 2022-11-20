using UnityEngine;
using UnityEngine.SceneManagement;

public class CampaignManager : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("Start");
    }
}