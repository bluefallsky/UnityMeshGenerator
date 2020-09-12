using UnityEngine;
using UnityMeshGenerator;

public class TestGenerateRoot : MonoBehaviour
{
	public MeshFilter triRect;

	private void Start()
	{
		triRect.mesh = MeshGenerator.TriRect.Generate(5.0f, 10.0f);
	}
}
