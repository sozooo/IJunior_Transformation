using System.Collections;
using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _isON;

    void Start()
    {
        StartCoroutine(SphereMove());
    }

    private IEnumerator SphereMove()
    {
        Vector3 startScale = transform.localScale;
        float scaleModifier = 1;

        while (_isON)
        {
            scaleModifier += _speed * Time.deltaTime;
            transform.localScale = startScale * scaleModifier;

            yield return null;
        }

        yield break;
    }
}
