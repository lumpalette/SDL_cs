using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The structure that defines a point (using floating point values).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FPoint">documentation</see> for more details.
/// </remarks>
/// <param name="x">The x coordinate.</param>
/// <param name="y">The y coordinate.</param>
/// <seealso cref="SDL.GetRectEnclosingPoints(SDL_FPoint[], ref SDL_FRect, out SDL_FRect)"/>
/// <seealso cref="SDL.PointInRect(ref SDL_FPoint, ref SDL_FRect)"/>
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