using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
      void Update ()
      {
            transform.Translate (0.01f, 0f, 0f);
      }
}
