using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform cube, sphere;

    public float speed = 3;

    private void Update()
    {
        Vector3 pos = Vector3.Lerp(cube.position, sphere.position, 0.5f * Time.deltaTime * speed);
        print(pos);

        cube.position = pos;

    }
}
