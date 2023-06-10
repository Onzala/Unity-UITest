using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    // Start is called before the first frame update
    public float hp;
    public Text HPtext;
    void Start()
    {
        DisplayHP();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Sleep() 
    {
        int randomValue = Random.Range(1, 11); // 生成 1 到 10 之間的隨機整數
        hp += randomValue;
        DisplayHP();
        Debug.Log("回血" + randomValue);
    }

    public void DisplayHP()
    {
        HPtext.text = hp.ToString();
    }
    
    public void BeAttacked()
    {
        int randomValue = Random.Range(1, 11); // 生成 1 到 10 之間的隨機整數
        hp -= randomValue;
        DisplayHP();
        Debug.Log("扣血" + randomValue);
    }
}
