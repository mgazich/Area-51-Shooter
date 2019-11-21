using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void loadMenu()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
