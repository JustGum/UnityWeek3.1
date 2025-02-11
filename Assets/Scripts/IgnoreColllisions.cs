using UnityEngine;

public class IgnoreColllisions : MonoBehaviour
{
    [SerializeField] private Collider[] _allColliders;

    private void Awake()
    {
        for (int i = 0; i < _allColliders.Length; i++)
        {
            for (int j = 0; j < _allColliders.Length; j++)
            {
                Physics.IgnoreCollision(_allColliders[i], _allColliders[j]);
            }
        }
    }
}
