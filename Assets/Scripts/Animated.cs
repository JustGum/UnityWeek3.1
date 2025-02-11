using UnityEngine;

public class Animated : MonoBehaviour
{
    [SerializeField] private PhysicsMaterial _defaultFriction;
    [SerializeField] private PhysicsMaterial _zeroFriction;

    [SerializeField] private Collider _leftFootCollider;
    [SerializeField] private Collider _rightFootCollider;

    public void SetLeftFriction()
    {
        _leftFootCollider.material = _defaultFriction;
        _rightFootCollider.material = _zeroFriction;
    }
    public void SetRightFriction()
    {
        _leftFootCollider.material = _zeroFriction;
        _rightFootCollider.material = _defaultFriction;
    }
}
