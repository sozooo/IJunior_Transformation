using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAbsoluteScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _isON;

    private float _rotateStep = -30.0f;

    void Start()
    {
        StartCoroutine(CubeAbsolute());
    }

    private IEnumerator CubeAbsolute()
    {
        Vector3 startScale = transform.localScale;
        float scaleModifier = 1;

        while (_isON)
        {
            scaleModifier += _speed * Time.deltaTime;
            transform.localScale = startScale * scaleModifier;
            transform.Rotate(_rotateStep * _speed * Time.deltaTime, 0, 0, Space.Self);
            transform.position += transform.forward * _speed * Time.deltaTime;

            yield return null;
        }

        yield break;
    }
}
