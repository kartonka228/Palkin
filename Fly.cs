using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fly : MonoBehaviour
{// Здоровье NPC
    public int healht = 5;
    // Уровень
    public int level = 1;
    // скорость
    public float speed = 1.5f;




    // Start is called before the first frame update 
    void Start()
    {
        healht += level;
        print("Здоровье:" + healht);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
        

    

