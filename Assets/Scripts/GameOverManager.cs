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
        int score = PlayerPrefs.GetInt("Score", 0);   // 여기서 0은 스코어가 저장안되어 있을 때 디폴트 값으로 0 으로 해주는 것.

        scoreLabel.text = score.ToString();   // 문자열로 변환
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayAgainPressed()
    {
        SceneManager.LoadScene("GameScene");  // 여기서 어떠한 씬을 로드할 수 있다.
    }


    public void QuitPressed()
    {
        Application.Quit();
    }


}
