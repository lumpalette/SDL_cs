using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// A bitmask of pressed mouse buttons, as reported by <see cref="SDL.GetMouseState(out float, out float)"/>, etc.
/// </summary>
/// <remarks>
/// This structure is a wrapper for a 32-bit unsigned integer. Refer to the official
/// <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
/// </remarks>
[Typedef]
public readonly struct SDL_MouseButtonFlags
{
	internal SDL_MouseButtonFlags(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_MouseButtonFlags cast)
		{
			return _value == cast._value;
		}
		return false;
	}

	/// <inheritdoc/>
	public override int GetHashCode()
	{
		return _value.GetHashCode();
	}

	/// <summary>
	/// Gets the numerical value of an <see cref="SDL_MouseButtonFlags"/> structure.
	/// </summary>
	/// <param name="x">The <see cref="SDL_MouseButtonFlags"/> to convert.</param>
	public static explicit operator uint(SDL_MouseButtonFlags x) => x._value;

	/// <summary>
	/// Converts a 32-bit unsigned integer into an <see cref="SDL_MouseButtonFlags"/> structure.
	/// </summary>
	/// <param name="x">The value to convert.</param>
	public static explicit operator SDL_MouseButtonFlags(uint x) => new(x);

	/// <summary>
	/// Compares if two <see cref="SDL_MouseButtonFlags"/> structures have the same numerical value.
	/// </summary>
	/// <param name="a">The <see cref="SDL_MouseButtonFlags"/> at the left side of the comparison.</param>
	/// <param name="b">The <see cref="SDL_MouseButtonFlags"/> at the right side of the comparison.</param>
	/// <returns>True if both <paramref name="a"/> and <paramref name="b"/> are the same, false otherwise.</returns>
	public static bool operator ==(SDL_MouseButtonFlags a, SDL_MouseButtonFlags b) => a._value == b._value;

	/// <summary>
	/// Compares if two <see cref="SDL_MouseButtonFlags"/> structures don't have the same numerical value.
	/// </summary>
	/// <param name="a">The <see cref="SDL_MouseButtonFlags"/> at the left side of the comparison.</param>
	/// <param name="b">The <see cref="SDL_MouseButtonFlags"/> at the right side of the comparison.</param>
	/// <returns>True if both <paramref name="a"/> and <paramref name="b"/> are not the same, false otherwise.</returns>
	public static bool operator !=(SDL_MouseButtonFlags a, SDL_MouseButtonFlags b) => a._value != b._value;

	private readonly uint _value;
}