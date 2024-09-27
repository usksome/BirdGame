using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // 점수 넣기 위해 생성한 TMP를 이용하기 때문에 TMPro 추가

public class GameManager : MonoBehaviour
{

    static public GameManager Instance;     // 게임 매니저라는 인스턴스를 다른 곳에서 접근하기 쉽도록 만들어줄 계획이다.                


    public GameObject wallPrefab;     // Prefab이 있어야 화면에 벽을 만들어 찍을 수 있다.
    public float spawnTerm = 4;       // 어느 정도 간격으로 벽을 만들 것인가?



    public TextMeshProUGUI scoreLabel;  // UI를 표시하기 위한 텍스트 프로는 이러한 타입명을 사용한다.

    public float score;



    float spawnTimer;   // 마지막으로 스폰한지 얼마나 지났는지를 갖다 체크하기 위해서 spawnTimer라는 변수를 만든다.



    private void Awake()   // awake는 start와 비슷하면서도 조금 다르다. 가장 커다란 차이점이라면 awake는 start보다 먼저 불리어진다는 거다.
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;     // 일단 0으로 세팅
        score = 0;          // 시작할 때 스코어는 0점으로 시작
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime; // 스폰 타이머가 시간이 지나감에 따라 올라간다.

        score += Time.deltaTime;      // 스코어는 얼마나 오래 버텼는지 표시할 것이다. 시간이 흐를 때마다 스코어가 올라가게 된다.
        scoreLabel.text = ((int)score).ToString();  


        if (spawnTimer > spawnTerm)    // 만약에흐른 시간이 spawnTerm 보다 길어졌으면... 이제는 여기다가 벽을 만들 것이다.
        { 
            spawnTimer -= spawnTerm;


            GameObject obj = Instantiate(wallPrefab);   // 벽을 갖다가 Prefab에서 실제 게임 오브젝트로 만드는 것이다.
            obj.transform.position = new Vector2(10, Random.Range(-2.75f, 2.75f));// 오브젝트의 위치를 정해줘야 한다.
        }


    }

}
