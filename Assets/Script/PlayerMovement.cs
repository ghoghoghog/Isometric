using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D rb;
   private float moveH, moveV;
   private PlayerAnimation playeranimation;
   public float moveSpeed = 2.0f;

   private void Awake()
   {
      rb = GetComponent<Rigidbody2D>();
      playeranimation = FindObjectOfType<PlayerAnimation>();
   }

   private void Update()
   {
      moveH = Input.GetAxisRaw("Horizontal");
      moveV = Input.GetAxisRaw("Vertical");
   }

   private void FixedUpdate()
   {
      Vector2 currentPos = rb.position;
      Vector2 inputVector = new Vector2(moveH, moveV).normalized * moveSpeed * Time.fixedDeltaTime;
      rb.MovePosition(currentPos+inputVector);
      playeranimation.SetDirection(new Vector2(moveH, moveV));
   }
}
