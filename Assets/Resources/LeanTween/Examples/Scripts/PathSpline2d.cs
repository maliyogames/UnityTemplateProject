// Date created: 2023-02-13
// Date updated: Date updated: 2023-02-13
// Date updated comment added to file for the first time
// Date updated comment added to file for the first time
// Date created: 2023-02-13
// Date created: 2023-02-13
// Date created: 2023-02-13
// Date created: 2023-02-13
using UnityEngine;
using System.Collections;
using DentedPixel;

public class PathSpline2d : MonoBehaviour {

	public Transform[] cubes;

	public GameObject dude1;
	public GameObject dude2;

	private LTSpline visualizePath;

	void Start () {
		Vector3[] path = new Vector3[] {
			cubes[0].position,
			cubes[1].position,
			cubes[2].position,
			cubes[3].position,
			cubes[4].position
		};

		visualizePath = new LTSpline( path );
		// move
		LeanTween.moveSpline(dude1, path, 10f).setOrientToPath2d(true).setSpeed(2f);

		// move Local
		LeanTween.moveSplineLocal(dude2, path, 10f).setOrientToPath2d(true).setSpeed(2f);
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.red;
		if(visualizePath!=null)
			visualizePath.gizmoDraw();
	}
}
