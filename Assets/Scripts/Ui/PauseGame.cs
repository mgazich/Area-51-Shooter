using UnityEngine;

public class PauseGame : MonoBehaviour
{
    GameObject[] pauseObjects;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("PauseMenu");
        unpauseGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseGame();
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                unpauseGame();
            }
        }
    }

    public void unpauseGame()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    public void pauseGame()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }
}
