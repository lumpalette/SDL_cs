using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A rectangle, with the origin at the upper left (using floating point values).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FRect">documentation</see> for more details.
/// </remarks>
/// <param name="x"> The x coordinate of the origin. </param>
/// <param name="y"> The y coordinate of the origin. </param>
/// <param name="width"> The width of this rectangle. </param>
/// <param name="height"> The height of this rectangle. </param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_FRect(float x, float y, float width, float height)
{
	/// <summary>
	/// The x coordinate of the upper-left corner of this rectangle.
	/// </summary>
	public float X = x;

	/// <summary>
	/// The y coordinate of the upper-left corner of this rectangle.
	/// </summary>
	public float Y = y;

	/// <summary>
	/// The width of this rectangle.
	/// </summary>
	public float Width = width;

	/// <summary>
	/// The height of this rectangle.
	/// </summary>
	public float Height = height;
}