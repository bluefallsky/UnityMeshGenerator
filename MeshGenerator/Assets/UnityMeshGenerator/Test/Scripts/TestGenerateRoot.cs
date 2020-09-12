using UnityEngine;
using UnityMeshGenerator;

public class TestGenerateRoot : MonoBehaviour
{
	public MeshFilter triRect;
	public MeshFilter slicedCircle;

	private void Start()
	{
		triRect.mesh = MeshGenerator.TriRect.Generate(5.0f, 10.0f);
		slicedCircle.mesh = MeshGenerator.SlicedCircle.Generate(2.0f, 10);
	}
}
