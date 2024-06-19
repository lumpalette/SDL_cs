using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The structure that defines a point using floating point values.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_FPoint">here</see> for more details.
/// </remarks>
/// <param name="x"> The x coordinate. </param>
/// <param name="y"> The y coordinate. </param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_FPoint(float x, float y)
{
	/// <summary>
	/// The x coordinate of this point.
	/// </summary>
	public float X = x;

	/// <summary>
	/// The y coordinate of this point.
	/// </summary>
	public float Y = y;
}