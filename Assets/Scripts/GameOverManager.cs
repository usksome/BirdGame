using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{


    public TextMeshProUGUI scoreLabel;



    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);   // ���⼭ 0�� ���ھ ����ȵǾ� ���� �� ����Ʈ ������ 0 ���� ���ִ� ��.

        scoreLabel.text = score.ToString();   // ���ڿ��� ��ȯ
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayAgainPressed()
    {
        SceneManager.LoadScene("GameScene");  // ���⼭ ��� ���� �ε��� �� �ִ�.
    }


    public void QuitPressed()
    {
        Application.Quit();
    }


}
