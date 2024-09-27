using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // ���� �ֱ� ���� ������ TMP�� �̿��ϱ� ������ TMPro �߰�

public class GameManager : MonoBehaviour
{

    static public GameManager Instance;     // ���� �Ŵ������ �ν��Ͻ��� �ٸ� ������ �����ϱ� ������ ������� ��ȹ�̴�.                


    public GameObject wallPrefab;     // Prefab�� �־�� ȭ�鿡 ���� ����� ���� �� �ִ�.
    public float spawnTerm = 4;       // ��� ���� �������� ���� ���� ���ΰ�?



    public TextMeshProUGUI scoreLabel;  // UI�� ǥ���ϱ� ���� �ؽ�Ʈ ���δ� �̷��� Ÿ�Ը��� ����Ѵ�.

    public float score;



    float spawnTimer;   // ���������� �������� �󸶳� ���������� ���� üũ�ϱ� ���ؼ� spawnTimer��� ������ �����.



    private void Awake()   // awake�� start�� ����ϸ鼭�� ���� �ٸ���. ���� Ŀ�ٶ� �������̶�� awake�� start���� ���� �Ҹ������ٴ� �Ŵ�.
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;     // �ϴ� 0���� ����
        score = 0;          // ������ �� ���ھ�� 0������ ����
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime; // ���� Ÿ�̸Ӱ� �ð��� �������� ���� �ö󰣴�.

        score += Time.deltaTime;      // ���ھ�� �󸶳� ���� ������� ǥ���� ���̴�. �ð��� �带 ������ ���ھ �ö󰡰� �ȴ�.
        scoreLabel.text = ((int)score).ToString();  


        if (spawnTimer > spawnTerm)    // ���࿡�帥 �ð��� spawnTerm ���� ���������... ������ ����ٰ� ���� ���� ���̴�.
        { 
            spawnTimer -= spawnTerm;


            GameObject obj = Instantiate(wallPrefab);   // ���� ���ٰ� Prefab���� ���� ���� ������Ʈ�� ����� ���̴�.
            obj.transform.position = new Vector2(10, Random.Range(-2.75f, 2.75f));// ������Ʈ�� ��ġ�� ������� �Ѵ�.
        }


    }

}
