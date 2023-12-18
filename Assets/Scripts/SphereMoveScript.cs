using System.Collections;
using UnityEngine;

public class SphereMoveScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _isON;

    void Start()
    {
        StartCoroutine(SphereMove(_speed));
    }

    private IEnumerator SphereMove(float speed)
    {
        while(_isON)
        {
            transform.position += transform.forward * speed * Time.deltaTime;

            yield return null;
        }

        yield break;
    }
}
