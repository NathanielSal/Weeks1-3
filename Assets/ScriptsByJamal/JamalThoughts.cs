using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class JamalThoughts : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 JamalHand = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = JamalHand;
    }
}
