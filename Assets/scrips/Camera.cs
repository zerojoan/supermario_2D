using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform target;
    public Vector3 offset;

    //vectores para limitar el mvimiento de de la camara en los ejes x y e
    public Vector2 limitX;
    public Vector2 limitY;

    public float interpolationRatio;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Mario_0").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //posicion deseada de la camara
        Vector3 desiredPosition = target.position + offset;
        //limitamos la posicion en x
        float clampX = Mathf.Clamp(desiredPosition.x, limitX.x , limitX.y);
        //limitamos la posicion en x
        float clampY = Mathf.Clamp(desiredPosition.y, limitY.x , limitY.y);

        Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);

        Vector3 lerpedPosition = Vector3.Lerp(transform.position, clampedPosition, interpolationRatio);

        transform.position = clampedPosition;
    }
}
