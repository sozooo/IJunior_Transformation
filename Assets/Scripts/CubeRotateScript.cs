using System.Collections;
using UnityEngine;

public class CubeRotateScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _isON;

    private float _fullRotate = 360.0f;

    void Start()
    {
        StartCoroutine(CubeRotate());
    }

    private IEnumerator CubeRotate()
    {
        while (_isON)
        {
            transform.Rotate(0, _fullRotate * _speed * Time.deltaTime, 0, Space.Self);

            yield return null;
        }

        yield break;
    }
}
