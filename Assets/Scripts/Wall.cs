using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed = 2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



    }


    private void FixedUpdate()    // 만든 벽은 새와 부딪혔을 때 물리 엔진 연산이 필요하기 때문에 움직임의 변화는 FixedUpdate에 넣도록 하겠다.
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);


        if (transform.position.x < -10) // 장애물이 왼쪽 화면 밖으로 나가면 사라지게...  만약에 x좌표가 -10보다 작아졌으면 
        {
            Destroy(gameObject);  // 사라지는 함, gameObject라고 써주면 이 스크립트가 붙어 있는 gameObject 자체를 destroy 하는 거다.
        }

    }



}
