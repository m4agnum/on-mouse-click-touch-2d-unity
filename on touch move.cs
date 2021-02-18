
// for pc development 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class your_script_name : MonoBehaviour
{

    Vector2 targetPos;
    public float movespeed;
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 1000f;

        if (Input.GetMouseButtonDown(0))
        {
            targetPos = mousePos;
        }

    }

    private void FixedUpdate()
    {
        ClickToMove();
    }

    void ClickToMove()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, movespeed);
    }
}




// for mobile development :

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class your_script_name  : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchposition = Camera.main.ScreenToWorldPoint(touch.position);
            touchposition.z = 0f;
            transform.position = touchposition;
        }
    }
}
