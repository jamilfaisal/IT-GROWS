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
        _userRotation = _playerTransform.rotation.eulerAngles + new Vector3(0, playerInput.x, 0);
        _playerTransform.rotation = Quaternion.Euler(_userRotation);

        Debug.Log("ran with input:" + playerInput.ToString());
        
        _playerRigidBody.velocity += _playerTransform.forward * playerInput.y * 0.25f;
    }

}
