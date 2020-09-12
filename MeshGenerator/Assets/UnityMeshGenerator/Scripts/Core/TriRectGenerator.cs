using UnityEngine;

namespace UnityMeshGenerator.Core
{
    public class TriRectGenerator
    {
        private const int VertCount = 4;
        private const int UvCount = 4;
        
        public Mesh Generate(float x, float y)
        {
            var mesh = new Mesh {name = $"TriangleRect - x:{x}, y:{y}"};

            //	set vert
            var halfX = x * 0.5f;
            var halfY = y * 0.5f;

            var verts = new Vector3[VertCount];
            verts[0] = new Vector3(halfX, 0.0f, halfY);
            verts[1] = new Vector3(-halfX, 0.0f, halfY);
            verts[2] = new Vector3(-halfX, 0.0f, -halfY);
            verts[3] = new Vector3(halfX, 0.0f, -halfY);

            mesh.vertices = verts;

            //	set tri
            var triCount = 2;
            var triangles = new int[triCount * 3];
            triangles[0] = 0;
            triangles[1] = 2;
            triangles[2] = 1;
            triangles[3] = 0;
            triangles[4] = 3;
            triangles[5] = 2;

            mesh.triangles = triangles;

            //	set normal
            var normalCount = 4;
            var normals = new Vector3[normalCount];
            for (var i = 0; i < normalCount; ++i)
            {
                normals[i] = Vector3.up;
            }

            mesh.normals = normals;

            //	set uv
            var uvs = new Vector2[UvCount];
            uvs[0] = new Vector2(1.0f, 1.0f);
            uvs[1] = new Vector2(-1.0f, 1.0f);
            uvs[2] = new Vector2(-1.0f, -1.0f);
            uvs[3] = new Vector2(1.0f, -1.0f);

            mesh.uv = uvs;

            return mesh;
        }
    }
}