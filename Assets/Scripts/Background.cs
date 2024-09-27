using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public float speed = 2;
    public float size = 19.2f;  // public을 안쓰면 inspector에서 보이지 않는다.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);   

        if (transform.position.x < -size)                                   
        {
            transform.Translate(new Vector3(size * 2, 0, 0));                // transform.Tranlate  19.2    (화면이 넘어가면 다시 뒤로 가서 연속적으로 배경이 보이도록 함)

        }

    }
}
