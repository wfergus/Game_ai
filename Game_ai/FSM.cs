using System;
using System.Collections.Generic;
using System.Text;


namespace Game_ai
{
    public class FSM : MonoBehaviour
    {
        public float elapsedTime;


        protected Transform playerTransform;

        protected Vector3 destPos;

        protected GameObject[] pointList;

        protected virtual void Initialize() { }
        protected virtual void FSMUpdate() { }
        protected virtual void FSMFixedUpdate() { }

        void Start()
        {
            Initialize();
        }
        void Update()
        {
            FSMUpdate();
        }

        void FixedUpdate()
        {
            FSMFixedUpdate();
        }
    }
}
