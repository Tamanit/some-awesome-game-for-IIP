using UnityEngine;

    public class MouvingBG : MonoBehaviour
    {
        public float movingSpeed = 60f;
        void FixedUpdate() => transform.position -= new Vector3(movingSpeed, 0) * Time.deltaTime;
    }

