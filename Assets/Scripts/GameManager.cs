using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject[] levels;
    public float currentStage = 0;
    public bool isReached = false;
    private bool isOver;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (currentStage == 5&& !isOver)
        {
            isOver = true;
            StartCoroutine("GameOver");
        }
        if (currentStage == 2 && FindObjectOfType<Camera>().orthographicSize < 22.5f)
        {
            FindObjectOfType<Camera>().orthographicSize += Time.deltaTime;
        }
        switch (currentStage)
        {
            case 0:
                if (isReached) return;
                levels[0].SetActive(false);
                levels[1].SetActive(false);
                levels[2].SetActive(true);
                isReached = true;
                break;
            case 1:
                if (isReached) return;
                levels[2].SetActive(false);
                levels[1].SetActive(false);
                levels[0].SetActive(true);
                FindObjectOfType<MoveCamera>().Move(new Vector3(40.25f, 10.25f, -10));
                FindObjectOfType<CoinGenerator>().Generate();
                isReached = true;
                break;
            case 2:
                if (isReached) return;
                levels[0].SetActive(false);
                levels[2].SetActive(false);
                levels[1].SetActive(true);
                FindObjectOfType<MoveCamera>().Move(new Vector3(60f, 21.5f, -10));
                isReached = true;
                break;
        }
    }
    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
}
