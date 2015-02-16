using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

namespace UnitySampleAssets._2D
{

    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D character;
        private bool jump;
		private bool stop;
		//var touch : Touch in Input.touches

        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
        }

        private void Update()
        {
			if (Input.touchCount > 0) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					jump = true;
				}
				if (Input.GetTouch (0).phase == TouchPhase.Ended) {
					stop = false;
				}
			}

            if(!jump)
            // Read the jump input in Update so button presses aren't missed.
            jump = CrossPlatformInputManager.GetButtonDown("Jump");
        }

        private void FixedUpdate()
        {
            // Read the inputs.
            //bool crouch = Input.GetKey(KeyCode.LeftControl);
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
			//if (Input.touchCount > 0){
			//	jump = true;
			//}

			if (Input.touchCount > 0) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					jump = true;
				}
				if (Input.GetTouch (0).phase == TouchPhase.Ended) {
					stop = true;
				}
			}
			character.Move(1, false, jump,stop);
            jump = false;
			stop = false;
        }
    }
}