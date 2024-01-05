using System.Collections;
using UnityEngine;

public class CubeRotateScript : ObjectClass
{
    private float _fullRotate = 360.0f;

    private void Start()
    {
        StartCoroutine(CubeRotate());
    }

    private IEnumerator CubeRotate()
    {
        while (IsOn)
        {
            transform.Rotate(0, _fullRotate * Speed * Time.deltaTime, 0, Space.Self);

            yield return null;
        }

        yield break;
    }
}
