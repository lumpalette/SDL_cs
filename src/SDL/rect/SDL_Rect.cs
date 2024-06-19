using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A rectangle, with the origin at the upper left using integers.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_Rect">here</see> for more details.
/// </remarks>
/// <param name="x"> The x coordinate of the origin. </param>
/// <param name="y"> The y coordinate of the origin. </param>
/// <param name="width"> The width of this rectangle. </param>
/// <param name="height"> The height of this rectangle. </param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_Rect(int x, int y, int width, int height)
{
	/// <inheritdoc/>
	public override readonly bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_Rect cast)
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

	public static bool operator ==(SDL_Rect a, SDL_Rect b) => (a.X == b.X) && (a.Y == b.Y) && (a.Width == b.Width) && (a.Height == b.Height);

	public static bool operator !=(SDL_Rect a, SDL_Rect b) => (a.X != b.X) || (a.Y != b.Y) || (a.Width != b.Width) || (a.Height != b.Height);

	public static explicit operator SDL_Rect(SDL_FRect r) => new((int)r.X, (int)r.Y, (int)r.Width, (int)r.Height);

	/// <summary>
	/// The x coordinate of the upper-left corner of this rectangle.
	/// </summary>
	public int X = x;

	/// <summary>
	/// The y coordinate of the upper-left corner of this rectangle.
	/// </summary>
	public int Y = y;

	/// <summary>
	/// The width of this rectangle.
	/// </summary>
	public int Width = width;

	/// <summary>
	/// The height of this rectangle.
	/// </summary>
	public int Height = height;
}