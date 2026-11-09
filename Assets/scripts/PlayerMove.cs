using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1;
    public bool playerA;
    void Update()
    {
        Vector3 dir = new Vector3(0, 0);

        if (playerA == true)
        {
            if (Keyboard.current.wKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.sKey.isPressed)
            {
                dir.y = -1;
            }

        }
        else
        {
            if (Keyboard.current.upArrowKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.downArrowKey.isPressed)
            {
                dir.y = -1;
            }

        }

        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
