using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static System.Math;

public class moveCamera : MonoBehaviour
{
    public Camera camera;

    public Player player1;

    public Player player2;

    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 previousPos = camera.transform.position;
        Vector3 posP1 = player1.transform.position;
        Vector3 posP2 = player2.transform.position;
        double dP1 = Sqrt(Pow(Abs(position.z - posP1.z), 2) + Pow(Abs(posP1.x - position.x), 2));
        position.x = (posP2.x - posP1.x)/ 2 + posP1.x;
        double theta = Acos((Abs(position.z - posP1.z)) / dP1) * 180 / PI; 
        if (theta > 36 && position.z > -.5f)
        {
            position.z -= .1f;
        }

        if (theta < 30 && position.z < 2)
        {
            position.z += .1f;
        }
        camera.transform.position = Vector3.Lerp(previousPos, position, Time.deltaTime * 10);
    }
}
