using UnityEngine;

public class Test : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
        
        Vector2 myOrigin = new Vector2(0.0f, 0.0f);
        Vector2 myPoint = new Vector2(3.0f, 2.0f);
        Debug.DrawLine(myOrigin, myPoint, Color.red);


    }
}
