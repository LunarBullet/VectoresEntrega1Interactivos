using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorManager : MonoBehaviour
{
    [SerializeField] Vector2 RedVector;
    [SerializeField] Vector2 GreenVector;

    [SerializeField] [Range(0, 1)] float magnitude;

    Vector2 blackDirection;
    Vector2 blueDirection;

    // Update is called once per frame
    void Update()
    {
        //DrawVector(Color.red, RedVector);
        DrawVector(Color.green, GreenVector);

        //yellowDirection = (GreenVector + (RedVector - GreenVector));

        blackDirection =  RedVector - GreenVector;

        blueDirection = blackDirection * magnitude + GreenVector;

        DrawVector(Color.black, GreenVector, blackDirection * magnitude);
        DrawVector(Color.blue, blueDirection);
    }

    void DrawVector(Color vectorColor, Vector2 endVector)
    {
        //Debug.DrawLine(baseVector, endVector, vectorColor);
        Debug.DrawLine(Vector2.zero, endVector, vectorColor);

    }

    void DrawVector(Color vectorColor,Vector2 baseVector , Vector2 endVector)
    {
        endVector = endVector + baseVector;
        Debug.DrawLine(baseVector, endVector, vectorColor);

    }


}
