using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Camera))]

public class DoorControl : MonoBehaviour
{

	public float distance = 5;
	public string door;
	public KeyCode key = KeyCode.F;
	private Camera cam;

	void Awake()
	{
		cam = GetComponent<Camera>();
	}

	void Update()
	{
		if (Input.GetKeyDown(key))
		{
			RaycastHit hit;
			Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
			if (Physics.Raycast(ray, out hit, distance))
			{
				var door = hit.transform.GetComponent<Door>();
				if (door != null)
				{
					door.enabled = true;
					door.Invert(transform);
				}
			}
		}
	}
}