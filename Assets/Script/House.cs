using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour {

    public GameObject houseExplode;
    public GameObject myHouse;
    public GameObject myFire;

    GameObject onFire;
    //public bool isKilled;
    //public GUIText score;
    private int myscore = 0;
    public static int score;

    int thehit = 0;
    private int hit;
    void Start()
    {
        hit = thehit;
        score = myscore;
    }
    void Update()
    {
       // Debug.Log(hit);

    }
    void OnCollisionEnter(Collision collision)
    {
        hit++;
        Quaternion rot = new Quaternion(-90, 0, 0 ,90);
        if (hit == 2)
        {
            onFire = (GameObject)Instantiate(myFire, transform.localPosition, rot);

        }
        if (hit >= 5)
        {
            Destroy(onFire, 0.5f);
            houseKill();
        }
    }
    void houseKill()
    {
        GameObject newexplosion = (GameObject)Instantiate(houseExplode, transform.localPosition, transform.localRotation);
        Destroy(myHouse,0.5f);
        score += 100;
    }

}
