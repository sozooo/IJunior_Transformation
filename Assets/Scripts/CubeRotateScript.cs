using System.Collections;
using UnityEngine;

public class CubeRotateScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _isON;

    void Start()
    {
        StartCoroutine(CubeRotate(_speed));
    }

    private IEnumerator CubeRotate(float speed)
    {
        while (_isON)
        {
            transform.Rotate(0, 360.0f * speed * Time.deltaTime, 0, Space.Self);

            yield return null;
        }

        yield break;
    }
}
