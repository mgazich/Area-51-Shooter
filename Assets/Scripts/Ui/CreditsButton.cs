using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{
    public void LoadCredits()
    {
        SceneManager.LoadScene("CreditsScreen");
    }

}