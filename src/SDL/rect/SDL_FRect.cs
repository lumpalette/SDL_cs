using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A rectangle, with the origin at the upper left using floating point values.
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
	/// <inheritdoc/>
	public override readonly bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_FRect cast)
		{
			return this == cast;
		}
		return false;
	}

	/// <inheritdoc/>
	public override readonly int GetHashCode()
	{
		return HashCode.Combine(X, Y, Width, Height);
	}

	public static bool operator ==(SDL_FRect a, SDL_FRect b) => (a.X == b.X) && (a.Y == b.Y) && (a.Width == b.Width) && (a.Height == b.Height);

	public static bool operator !=(SDL_FRect a, SDL_FRect b) => (a.X != b.X) || (a.Y != b.Y) || (a.Width != b.Width) || (a.Height != b.Height);

	public static explicit operator SDL_FRect(SDL_Rect r) => new(r.X, r.Y, r.Width, r.Height);

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