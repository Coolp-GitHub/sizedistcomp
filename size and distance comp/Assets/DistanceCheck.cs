using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCheck : MonoBehaviour
{
    public Transform obj1;

    public Transform obj2;


    [SerializeField] private Vector3 pos1;
    [SerializeField] private Vector3 pos2;
    [SerializeField] private Vector3 posRat;


    void Start()
    {
        pos1 = new Vector3(obj1.position.x, obj1.position.y, obj1.position.z);
        pos2 = new Vector3(obj2.position.x, obj2.position.y, obj2.position.z);

    }


    void Update()
    {
        if (obj1.position.x > obj2.position.x)
        {
            posRat = new Vector3(pos2.x / pos1.x, 0, 0);
        }
        else if (obj1.position.x < obj2.position.x)
        {
            posRat = new Vector3(pos1.x / pos2.x, 0, 0);
        }
        else if (obj1.position.x == obj2.position.x)
        {
            posRat = new Vector3(1, 1, 1);
        }



        //set x, now time to set y



        if (obj1.position.y > obj2.position.y)
        {
            posRat = new Vector3(posRat.x, pos2.y / pos1.y, 0);
        }
        else if (obj1.position.y < obj2.position.y)
        {
            posRat = new Vector3(posRat.x, pos1.y / pos2.y, 0);
        }
        else if (obj1.position.y == obj2.position.y)
        {
            posRat = new Vector3(posRat.x, 1);
        }





        if (posRat.x >= 0.5 && posRat.y >= 0.5)
        {
            //yourcode
        }
        else if (posRat.x >= 0.2 || posRat.y >= 0.2)
        {
            //yourcode
        }
        else
        {
            //yourcode
        }



    }
}
