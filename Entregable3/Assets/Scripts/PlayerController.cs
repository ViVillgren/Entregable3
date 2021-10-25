using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        ScaleGameObject(new Vector3(0.5f, 0, 0), KeyCode.X);
        ScaleGameObject(new Vector3(0, 0.5f, 0), KeyCode.Y);
        ScaleGameObject(new Vector3(0, 0, 0.5f), KeyCode.Z);
    }

    public void ScaleGameObject(Vector3 scale, KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode))
        {
            transform.localScale += scale;
        }
    }
}

