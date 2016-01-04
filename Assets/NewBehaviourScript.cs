using UnityEngine;
using System.Collections;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform abc;
    public int val;
    // Use this for initialization
    void Start()
    {
        Debug.Log("helloworld2");
        Debug.Log(abc.position);
        Debug.Log(val);

        Invoke("print1", 3);

        Book book1 = new Book();
        book1.title = "タイトルです";
        book1.name = "山田太郎";
        book1.lent = false;

        print(book1.title);
        print(book1.name);
        print(book1.lent);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(DateTime.Now.Millisecond);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("oncollisionEnter");
        Destroy(collision.gameObject);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("oncontrollercolliderHit");
    }

    void print1()
    {
        string hiki1 = "JJJ";
        Debug.Log("printdesu:" + hiki1);
    }

    class Book
    {
        public string title;
        public string name = "山田";
        public bool lent = true;
    }
}
