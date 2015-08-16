using UnityEngine;
using System.Collections;

public class GenerateTriRectMesh : MonoBehaviour
{
	MeshFilter		mMeshFilter;

	void Awake()
	{
		if( mMeshFilter == null )
		{
			mMeshFilter = gameObject.GetComponent<MeshFilter>();

			if( mMeshFilter == null )
			{
				mMeshFilter = gameObject.AddComponent<MeshFilter>();
			}
		}
	}

	void Start()
	{
		mMeshFilter.mesh = MeshGenerator.Instance.GenTriRect( 5.0f, 10.0f );
	}
}
