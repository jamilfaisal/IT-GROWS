using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody _playerRigidBody;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private CharacterController _playerCharacterController;

    private Vector3 _playerVelocity;
    private float _playerSpeed = 2.0f;
    public float thrust = 20f;
    private Vector3 _userRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void MoveCharacter(Vector2 playerInput) {
        _userRotation = _playerTransform.rotation.eulerAngles + new Vector3(0, playerInput[0], 0);
        _playerTransform.rotation = Quaternion.Euler(_userRotation);
        

        // Movement forward and backward
        // 1. First way with velocity
        // _playerRigidBody.velocity += _playerTransform.forward * playerInput[1];
        // 2. Second way with addForce
        // Vector3 v3Force = transform.forward * playerInput[1];
        // _playerRigidBody.AddForce(v3Force);
        // 3. Third way with CharacterController
        if (playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        Vector3 move = new Vector3(playerInput[0], 0, playerInput[1]);
        controller.Move(move * Time.deltaTime * playerSpeed);
        if (move != Vector3.zero)
        {
            _playerTransform.forward = move;
        }
        controller.Move(playerVelocity * Time.deltaTime);
    }

}
