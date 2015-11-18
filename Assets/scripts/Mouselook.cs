
using UnityEngine;

// Very simple smooth mouselook modifier for the MainCamera in Unity
// by Francis R. Griffiths-Keam - www.runningdimensions.com

[AddComponentMenu("Camera/Simple Smooth Mouse Look ")]
public class Mouselook : MonoBehaviour
{
	public enum RotationAxis  {Xmouse = 1, Ymouse = 2}
	public RotationAxis XYrotation = RotationAxis.Xmouse | RotationAxis.Ymouse;

	public float Xsensitivity; // Mouse  Sensitivity
	public float Xmin = -360f; // we rotate our character 180 degrees around the x-axis (we nee to determine the limits of rotation between both limits (Min+Max)
	public float Xmax = 360f;
	
	private float Xrotation = 0f; // instance rotation of private variable
	
	public Quaternion orginalRotation; // a variable consisting of  our original rotation

	public float Ysensitivity;
	public float Ymin = -60f; // up… 
	public float Ymax = 90f; // … and down position limit
	
	private float Yrotation = 0f;

	void Start(){
			orginalRotation = transform.localRotation;
	}

	void Update(){    
		float Ysensitivity = Manager.Instance.mySens;
		float Xsensitivity = Manager.Instance.mySens;

		Xrotation += Input.GetAxis("Mouse X") * Xsensitivity * Time.deltaTime;  // multiply the instance value on x-axis by time variable
		Quaternion Xquaternion = Quaternion.AngleAxis(Xrotation, Vector3.up); // object representing angle rotation on x-axis
		transform.localRotation = orginalRotation * Xquaternion; 

		if(XYrotation == RotationAxis.Ymouse)
		{    
			Yrotation -= Input.GetAxis("Mouse Y") * Ysensitivity * Time.deltaTime; // multiply the instance value on x-axis by time variable
			Yrotation = LimitLookAngle(Yrotation, Ymin, Ymax);
			Quaternion Yquaternion = Quaternion.AngleAxis(Yrotation, Vector3.right); //object representing  angle rotation on y-axis
			transform.localRotation = orginalRotation * Yquaternion; 
		}
	}

	private float LimitLookAngle ( float angle, float min, float max)
	{
		if(angle < -360)
			angle += 360;
		if(angle > 360)
			angle -= 360;
		
		return Mathf.Clamp(angle, min, max);
	}

}