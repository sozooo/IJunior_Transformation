using System.Collections;
using UnityEngine;

public class CubeAbsoluteScript : ObjectClass
{
    private float _fullRotate = 360.0f;

    private void Start()
    {
        StartCoroutine(CubeAbsolute());
    }

    private IEnumerator CubeAbsolute()
    {
        Vector3 startScale = transform.localScale;
        float scaleModifier = 1;

        while (IsOn)
        {
            scaleModifier += Speed * Time.deltaTime;
            transform.localScale = startScale * scaleModifier;
            transform.Rotate(0, _fullRotate * Speed * Time.deltaTime, 0, Space.Self);
            transform.position += transform.forward * Speed * Time.deltaTime;

            yield return null;
        }

        yield break;
    }
}
