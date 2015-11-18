using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public static Player current;

	public CarryScript hand;
	public kauhaMechanics kauha;
    public Camera view;

    public float speed = 2f;

    public float sensitivity = 0.5f;
    public float viewLimit = 90f;
    public bool inverted = false;

    private CharacterController character;
    private Vector2 lookRotation;

	void Awake() {
        character = GetComponent<CharacterController>();
		current = this;
	}

    void Update() {
        // Mouse rotation
        lookRotation.x += (Input.GetAxis("Mouse X") * (sensitivity * 300f)) * Time.deltaTime;
        lookRotation.y = Mathf.Clamp(lookRotation.y + (((inverted ? 1f : -1f) * Input.GetAxis("Mouse Y")) * (sensitivity * 300f)) * Time.deltaTime, -viewLimit, viewLimit);
        transform.rotation = Quaternion.Euler(transform.rotation.x, lookRotation.x, transform.rotation.z);
        view.transform.localRotation = Quaternion.Euler(lookRotation.y, transform.localRotation.y, transform.localRotation.z);

        // Movement
        character.Move(transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal") * speed, Physics.gravity.y, Input.GetAxis("Vertical") * speed)) * Time.deltaTime);
    }
}
