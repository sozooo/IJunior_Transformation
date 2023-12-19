using System.Collections;
using UnityEngine;

public class SphereMoveScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _isON;

    void Start()
    {
        StartCoroutine(SphereMove());
    }

    private IEnumerator SphereMove()
    {
        while(_isON)
        {
            transform.position += transform.forward * _speed * Time.deltaTime;

            yield return null;
        }

        yield break;
    }
}
