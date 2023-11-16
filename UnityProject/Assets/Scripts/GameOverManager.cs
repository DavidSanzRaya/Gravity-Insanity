using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject speedlines;
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject gameOverMenu;
    private Camera cam;
    private bool gameOver;

    private void Start()
    {
        cam = Camera.main;
        gameOver = false;
    }

    public void ShowEndAnimation()
    {
        GetComponent<Animator>().enabled = true;
        GameObject sl = Instantiate(speedlines, transform.position, Quaternion.identity);
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);
        Camera.main.orthographicSize /= 2;
        gameOver = true;
        gameOverCanvas.SetActive(true);
    }

    private void Update()
    {
        if (gameOver)
        {
            Invoke("ShowGameOverText", 1);
        }
    }

    private void ShowGameOverText()
    {
        if (Input.anyKey)
        {
            ShowGameOverMenu();
        }
    }

    private void ShowGameOverMenu()
    {
        Time.timeScale = 0;
        gameOverMenu.SetActive(true);
    }
}
