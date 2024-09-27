using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float gravity = 10f;  // �߷�
    public float accel = 10f;   // ������ �� ��� ���ӵ�
    float v;   // ������ �ӵ� v

    public AudioClip upSound;  // ���� �ö� �� ���� �Ҹ� ����
    public AudioClip downSound; // �Ʒ��� ������ �� ���� �Ҹ� ����

    // Start is called before the first frame update
    void Start()
    {
        v = 0; // ��ó�� ������ �����ϸ� ������ �ӵ��� 0���� �����Ѵ�.
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump"))   // ��ư�� ������ �� �Ҹ��� �ѹ� ������
        {
            GetComponent<AudioSource>().PlayOneShot(upSound);    // PlayOneShot... ȿ���� �ѹ� �÷��� �ش޶�
        }


        if (Input.GetButtonUp("Jump"))    // ��ư�� ���� �� �Ҹ��� �ѹ� ������
        {
            GetComponent<AudioSource>().PlayOneShot(downSound);
        }




        if (Input.GetButton("Jump"))               // ���� Ű�� ���� �ִ� ������ �� �� ������ ���´�.
                                                   // 
        {
            v -= accel * Time.deltaTime;           // y��ǥ�� ���̳ʽ��� �����̴�.
        }

        else
        {
            v += gravity * Time.deltaTime;
        }

    }


    private void FixedUpdate()    // ���� �ùķ��̼��� �� �� ������ �������� �� �Լ��� �ҷ����ٴ� �� ������ �� ���� �Ŵ�.
                                
    {
        transform.Translate(Vector2.down* v * Time.fixedDeltaTime);   // �̷��� ���� ���� ������ ���ؼ� �������� �Ǵ�, ��ȣ�ۿ��ؾ� �Ǵ� ��ü���� �������� ����ٰ� ���Ƴִ� �� ������ ���ؼ� ����.
    }


    private void OnCollisionEnter2D(Collision2D collision)     // �� ��ũ��Ʈ�� �پ� �ִ� Colider�� �ٸ� Colider�� �浹���� �� �ڵ����� �Ҹ��� �Լ���.
    {

        if (collision.gameObject.tag == "Wall")     // �ε��� ���� ������Ʈ�� �±װ� Wall �̶�� GameOverScene ���� �Ѿ��.
        {
            float score = GameManager.Instance.score;  

            PlayerPrefs.SetInt("Score", (int)score);

            PlayerPrefs.Save();   
            
            SceneManager.LoadScene("GameOverScene");
            
        }


        Debug.Log("Crash!");
    }


}
