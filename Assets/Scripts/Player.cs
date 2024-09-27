using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float gravity = 10f;  // 중력
    public float accel = 10f;   // 눌렀을 때 상승 가속도
    float v;   // 현재의 속도 v

    public AudioClip upSound;  // 위로 올라갈 때 내는 소리 변수
    public AudioClip downSound; // 아래로 내려갈 때 내는 소리 변수

    // Start is called before the first frame update
    void Start()
    {
        v = 0; // 맨처럼 게임이 시작하면 현재의 속도는 0에서 시작한다.
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump"))   // 버튼을 눌렀을 때 소리가 한번 나오고
        {
            GetComponent<AudioSource>().PlayOneShot(upSound);    // PlayOneShot... 효과를 한번 플레이 해달라
        }


        if (Input.GetButtonUp("Jump"))    // 버튼을 땠을 때 소리가 한번 나오고
        {
            GetComponent<AudioSource>().PlayOneShot(downSound);
        }




        if (Input.GetButton("Jump"))               // 점프 키가 눌려 있는 상태일 때 이 안으로 들어온다.
                                                   // 
        {
            v -= accel * Time.deltaTime;           // y좌표가 마이너스면 위쪽이다.
        }

        else
        {
            v += gravity * Time.deltaTime;
        }

    }


    private void FixedUpdate()    // 물리 시뮬레이션을 할 때 일정한 가격으로 이 함수가 불려진다는 걸 보장할 때 쓰는 거다.
                                
    {
        transform.Translate(Vector2.down* v * Time.fixedDeltaTime);   // 이렇게 쓰면 물리 연산을 통해서 움직여야 되는, 상호작용해야 되는 물체들의 움직임을 여기다가 몰아넣는 게 나중을 위해서 좋다.
    }


    private void OnCollisionEnter2D(Collision2D collision)     // 이 스크립트가 붙어 있는 Colider가 다른 Colider와 충돌했을 때 자동으로 불리는 함수다.
    {

        if (collision.gameObject.tag == "Wall")     // 부딪힌 게임 오브젝트의 태그가 Wall 이라면 GameOverScene 으로 넘어간다.
        {
            float score = GameManager.Instance.score;  

            PlayerPrefs.SetInt("Score", (int)score);

            PlayerPrefs.Save();   
            
            SceneManager.LoadScene("GameOverScene");
            
        }


        Debug.Log("Crash!");
    }


}
