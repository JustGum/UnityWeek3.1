using UnityEngine;

[RequireComponent (typeof(ConfigurableJoint))]
public class PhysicalBodyPart : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private ConfigurableJoint _joint;
    private Quaternion _startRotation;

    void Start()
    {
        _joint = GetComponent<ConfigurableJoint>();
        _startRotation = transform.localRotation;
    }

    void FixedUpdate()
    {
        _joint.targetRotation = Quaternion.Inverse(_target.rotation) * _startRotation;
    }
}
