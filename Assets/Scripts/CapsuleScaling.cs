using System.Collections;
using UnityEngine;

public class CapsuleScaling : ObjectClass
{
    private void Start()
    {
        StartCoroutine(SphereMove());
    }

    private IEnumerator SphereMove()
    {
        Vector3 startScale = transform.localScale;
        float scaleModifier = 1;

        while (IsOn)
        {
            scaleModifier += Speed * Time.deltaTime;
            transform.localScale = startScale * scaleModifier;

            yield return null;
        }

        yield break;
    }
}
