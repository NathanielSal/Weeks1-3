using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamalsWords : MonoBehaviour
{
    float JamalFarst = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Jpos = transform.position;
        Jpos.x += JamalFarst;
        transform.position = Jpos;

        Vector2 ScreenSpace = Camera.main.WorldToScreenPoint(Jpos);
        if (ScreenSpace.x < 0 || ScreenSpace.x > Screen.width)
        {
            JamalFarst = JamalFarst * -1;
        }
    }
}
