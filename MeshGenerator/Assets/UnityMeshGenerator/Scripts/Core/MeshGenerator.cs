using UnityMeshGenerator.Core;

namespace UnityMeshGenerator
{
	public static class MeshGenerator
	{
		public static readonly TriRectGenerator TriRect = new TriRectGenerator();
		public static readonly SlicedCircleGenerator SlicedCircle = new SlicedCircleGenerator();
	}
}