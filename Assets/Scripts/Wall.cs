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


    private void FixedUpdate()    // ���� ���� ���� �ε����� �� ���� ���� ������ �ʿ��ϱ� ������ �������� ��ȭ�� FixedUpdate�� �ֵ��� �ϰڴ�.
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);


        if (transform.position.x < -10) // ��ֹ��� ���� ȭ�� ������ ������ �������...  ���࿡ x��ǥ�� -10���� �۾������� 
        {
            Destroy(gameObject);  // ������� ��, gameObject��� ���ָ� �� ��ũ��Ʈ�� �پ� �ִ� gameObject ��ü�� destroy �ϴ� �Ŵ�.
        }

    }



}
