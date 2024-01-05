using System.Collections;
using UnityEngine;

public class SphereMoveScript : ObjectClass
{
    private void Start()
    {
        StartCoroutine(SphereMove());
    }

    private IEnumerator SphereMove()
    {
        while(IsOn)
        {
            transform.position += transform.forward * Speed * Time.deltaTime;

            yield return null;
        }

        yield break;
    }
}
