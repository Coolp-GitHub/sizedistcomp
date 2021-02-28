using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChecker : MonoBehaviour
{
    public Transform obj1;

    public Transform obj2;

    
    [SerializeField] private Vector3 size1;
    [SerializeField] private Vector3 size2;
    [SerializeField] private Vector3 sizeRat;


    void Start()
    {
        size1 = new Vector3(obj1.localScale.x, obj1.localScale.y, obj1.localScale.z);
        size2 = new Vector3(obj2.localScale.x, obj2.localScale.y, obj2.localScale.z);
        
    }

    
    void Update()
    {
        if(obj1.localScale.x > obj2.localScale.x)
        {
            sizeRat = new Vector3(size2.x / size1.x,0,0);
        }
        else if(obj1.localScale.x < obj2.localScale.x)
        {
            sizeRat = new Vector3(size1.x / size2.x,0,0);
        }else if(obj1.localScale.x == obj2.localScale.x)
        {
            sizeRat = new Vector3(1,1,1);
        }



        //set x, now time to set y



        if (obj1.localScale.y > obj2.localScale.y)
        {
            sizeRat = new Vector3(sizeRat.x, size2.y / size1.y, 0);
        }
        else if (obj1.localScale.y < obj2.localScale.y)
        {
            sizeRat = new Vector3(sizeRat.x, size1.y / size2.y, 0);
        }
        else if (obj1.localScale.y == obj2.localScale.y)
        {
            sizeRat = new Vector3(sizeRat.x, 1, 1);
        }

        if (sizeRat.x > 0.5 && sizeRat.y >= 0.5)
        {
            ////yourcode
        }
        else if (sizeRat.x > 0.2 || sizeRat.y >= 0.2)
        {
            //yourcode
        }
        else
        {
            //yourcode
        }



    }
}
