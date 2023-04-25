using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
  public float rotSpeed = 3.0f;

  Vector3 rotAmount = Vector3.zero;

  private void Start()
  {
    rotAmount = new Vector3(rotSpeed * Random.Range(0f, 1f),
            rotSpeed * Random.Range(0f, 1f),
            rotSpeed * Random.Range(0f, 1f));
  }

  // Update is called once per frame
  void Update()
  {
    transform.Rotate(rotAmount * Time.deltaTime);
  }
}
