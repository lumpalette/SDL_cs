using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// SDL mouse instance ID.
/// </summary>
/// <remarks>
/// This structure is a wrapper for a 32-bit unsigned integer.
/// </remarks>
[Wrapper]
public readonly struct SDL_MouseId
{
	internal SDL_MouseId(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_MouseId cast)
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
	/// Gets the numerical value of an <see cref="SDL_MouseId"/> structure.
	/// </summary>
	/// <param name="x">The <see cref="SDL_MouseId"/> to convert.</param>
	public static explicit operator uint(SDL_MouseId x) => x._value;

	/// <summary>
	/// Converts a 32-bit unsigned integer into an <see cref="SDL_MouseId"/> structure.
	/// </summary>
	/// <param name="x">The value to convert.</param>
	public static explicit operator SDL_MouseId(uint x) => new(x);

	/// <summary>
	/// Compares if two <see cref="SDL_MouseId"/> structures have the same numerical value.
	/// </summary>
	/// <param name="a">The <see cref="SDL_MouseId"/> at the left side of the comparison.</param>
	/// <param name="b">The <see cref="SDL_MouseId"/> at the right side of the comparison.</param>
	/// <returns>True if both <paramref name="a"/> and <paramref name="b"/> are the same, false otherwise.</returns>
	public static bool operator ==(SDL_MouseId a, SDL_MouseId b) => a._value == b._value;

	/// <summary>
	/// Compares if two <see cref="SDL_MouseId"/> structures don't have the same numerical value.
	/// </summary>
	/// <param name="a">The <see cref="SDL_MouseId"/> at the left side of the comparison.</param>
	/// <param name="b">The <see cref="SDL_MouseId"/> at the right side of the comparison.</param>
	/// <returns>True if both <paramref name="a"/> and <paramref name="b"/> are not the same, false otherwise.</returns>
	public static bool operator !=(SDL_MouseId a, SDL_MouseId b) => a._value != b._value;

	private readonly uint _value;
}