using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody _playerRigidBody;
    [SerializeField] private Transform _playerTransform;

    private Vector3 _userRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void MoveCharacter(Vector2 playerInput) {
        // Camera rotation
        _userRotation = _playerTransform.rotation.eulerAngles + new Vector3(0, playerInput.x, 0);
        _playerTransform.rotation = Quaternion.Euler(_userRotation);

        // Player move forward
        _playerRigidBody.velocity += _playerTransform.forward * playerInput.y * 0.1f;
    }

}
