using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public TextMeshProUGUI timer;
    public static GameOver instance;
    public GameObject endscreen;
    public float deadlineTime;
    bool gameover = false;
    public delegate void Loop();
    public Loop loop;
    Player player;

    public void Start()
    {
        player = FindAnyObjectByType<Player>();
        player.OnDeath += Gameover;
        endscreen.SetActive(false);
    }

    public void Awake()
    {
        instance = this;
    }

    public void Gameover()
    {
        if (gameover)
        {
            return;
        }

        Text.text = ("Game Over");
        endscreen.SetActive(true);
        gameover = true;
    }
   public void WinG()
    {
        if (gameover)
        {
            return;
        }

        Text.text = ("You win");
        endscreen.SetActive(true);
        gameover = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        float seconds = deadlineTime - Time.timeSinceLevelLoad;
        timer.text = ((int)seconds / 60).ToString("0") + ":" + (seconds % 60).ToString("00");

        if (seconds < 0)
        {
            TimeOver();
        }
    }
    private void OnDestroy()
    {
        if (player != null)
        player.OnDeath -= Gameover;
    }
  
    void TimeOver()
    {
        loop?.Invoke();
    }
}