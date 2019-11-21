using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    GameObject Player;
    PauseGame pauseGame;

    private void Start()
    {
        Player = GameObject.Find("Player");
        pauseGame = Player.GetComponent<PauseGame>();
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
        pauseGame.unpauseGame();

    }
}
