using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _torch;
    [SerializeField] private Transform _torchSpawnPoint;
    private void Start()
    {
        Instantiate(_torch, _torchSpawnPoint.position, _torchSpawnPoint.rotation);
    }
}
