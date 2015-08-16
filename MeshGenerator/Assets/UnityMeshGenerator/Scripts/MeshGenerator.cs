using UnityEngine;
using System.Collections;

public class MeshGenerator
{
	#region Singleton
	private	static MeshGenerator mInstance;
	public	static MeshGenerator Instance{
		get{
			if( mInstance == null )
			{
				mInstance = new MeshGenerator();
			}
			return mInstance;
		}
	}
	#endregion

	#region Generation
	public Mesh GenTriRect( float x, float y )
	{
		Mesh mesh = new Mesh();
		mesh.name = string.Format( "TriangleRect - x:{0}, y:{1}", x, y );

		//	set vert
		int vertCount = 4;
		float halfX = x*0.5f;
		float halfY = y*0.5f;

		Vector3[] verts = new Vector3[vertCount];
		verts[0] = new Vector3(	halfX,	0.0f,	halfY	);
		verts[1] = new Vector3(	-halfX,	0.0f,	halfY	);
		verts[2] = new Vector3(	-halfX,	0.0f,	-halfY	);
		verts[3] = new Vector3(	halfX,	0.0f,	-halfY	);
		
		mesh.vertices = verts;

		//	set tri
		int triCount = 2;
		int[] triangles = new int[triCount*3];
		triangles[0] = 0;
		triangles[1] = 2;
		triangles[2] = 1;
		triangles[3] = 0;
		triangles[4] = 3;
		triangles[5] = 2;

		mesh.triangles = triangles;

		//	set normal
		int normalCount = 4;
		Vector3[] normals = new Vector3[normalCount];
		for( int i=0; i<normalCount; ++i )
		{
			normals[i] = Vector3.up;
		}
		
		mesh.normals = normals;

		//	set uv
		int uvCount = 4;
		Vector2[] uvs = new Vector2[uvCount];
		uvs[0] = new Vector2(	1.0f,	1.0f	);
		uvs[1] = new Vector2(	-1.0f,	1.0f	);
		uvs[2] = new Vector2(	-1.0f,	-1.0f	);
		uvs[3] = new Vector2(	1.0f,	-1.0f	);

		mesh.uv = uvs;

		return mesh;
	}
	#endregion
}
