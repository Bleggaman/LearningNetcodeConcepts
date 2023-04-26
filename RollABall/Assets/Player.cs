using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Player : MonoBehaviour
{

  public InputAction playerMovement;
  [SerializeField] private TextMeshProUGUI scoreLabel;
  [SerializeField] private TextMeshProUGUI winLabel;
  public Rigidbody rb;
  public float speed = 3.0f;

  Vector2 input = Vector2.zero;
  int score = 0;

  private void OnEnable()
  {
    playerMovement.Enable();
  }

  private void OnDisable()
  {
    playerMovement.Disable();
  }

  // Update is called once per frame
  void Update()
  {
    input = playerMovement.ReadValue<Vector2>();
  }

  private void FixedUpdate()
  {
    rb.velocity = new Vector3(input.x * speed, 0, input.y * speed);
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Collectible"))
    {
      Destroy(other.gameObject);
      score++;
      scoreLabel.text = "Score: " + score.ToString();
      if (GameObject.FindGameObjectsWithTag("Collectible").Length <= 1)
      {
        winLabel.enabled = true;
      }
    }
  }
}
