
using UnityEngine;

public class Boom : MonoBehaviour
{
    [SerializeField]
    private GameObject _boomPrefab;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(_boomPrefab);
        }
    }
}
