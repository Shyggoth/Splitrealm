using UnityEngine;

namespace Splitrealm
{
    public class CameraMovement : MonoBehaviour
    {
        public float panSpeed = 20f;
        public float panBorderTRhickness = 10f;
        public Vector2 panLimit;

        void Update()
        {
            Vector3 pos = transform.position;

            if (Input.GetKey("d"))
                pos.x += panSpeed * Time.deltaTime;

            if (Input.GetKey("a"))
                pos.x -= panSpeed * Time.deltaTime;

            pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
            transform.position = pos;
        }
    }
}