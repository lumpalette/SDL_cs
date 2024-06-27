using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// SDL properties ID.
/// </summary>
/// <remarks>
/// This structure is a wrapper for a 32-bit unsigned integer. Refer to the official
/// <see href="https://wiki.libsdl.org/SDL3/SDL_PropertiesID">documentation</see> for more details.
/// </remarks>
[Wrapper]
public readonly struct SDL_PropertiesId
{
	internal SDL_PropertiesId(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_PropertiesId cast)
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
	/// Gets the numerical value of an <see cref="SDL_PropertiesId"/> structure.
	/// </summary>
	/// <param name="x">The <see cref="SDL_PropertiesId"/> to convert.</param>
	public static explicit operator uint(SDL_PropertiesId x) => x._value;

	/// <summary>
	/// Converts a 32-bit unsigned integer into an <see cref="SDL_PropertiesId"/> structure.
	/// </summary>
	/// <param name="x">The value to convert.</param>
	public static explicit operator SDL_PropertiesId(uint x) => new(x);

	/// <summary>
	/// Compares if two <see cref="SDL_PropertiesId"/> structures have the same numerical value.
	/// </summary>
	/// <param name="a">The <see cref="SDL_PropertiesId"/> at the left side of the comparison.</param>
	/// <param name="b">The <see cref="SDL_PropertiesId"/> at the right side of the comparison.</param>
	/// <returns>True if both <paramref name="a"/> and <paramref name="b"/> are the same, false otherwise.</returns>
	public static bool operator ==(SDL_PropertiesId a, SDL_PropertiesId b) => a._value == b._value;

	/// <summary>
	/// Compares if two <see cref="SDL_PropertiesId"/> structures don't have the same numerical value.
	/// </summary>
	/// <param name="a">The <see cref="SDL_PropertiesId"/> at the left side of the comparison.</param>
	/// <param name="b">The <see cref="SDL_PropertiesId"/> at the right side of the comparison.</param>
	/// <returns>True if both <paramref name="a"/> and <paramref name="b"/> are not the same, false otherwise.</returns>
	public static bool operator !=(SDL_PropertiesId a, SDL_PropertiesId b) => a._value != b._value;

	/// <summary>
	/// An invalid/null set of properties. Used when a function that returns an <see cref="SDL_PropertiesId"/> fails or when
	/// you don't need/is not required to pass a set of properties to a function.
	/// </summary>
	public static SDL_PropertiesId Invalid => new(0);

	private readonly uint _value;
}