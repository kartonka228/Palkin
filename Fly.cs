using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fly : MonoBehaviour
{// �������� NPC
    public int healht = 5;
    // �������
    public int level = 1;
    // ��������
    public float speed = 1.5f;




    // Start is called before the first frame update 
    void Start()
    {
        healht += level;
        print("��������:" + healht);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
        

    

