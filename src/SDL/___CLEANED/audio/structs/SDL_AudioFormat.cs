using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Audio format flags.
/// </summary>
/// <remarks>
/// The structure is a wrapper for a 16-bit unsigned integer. Refer to the official
/// <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
/// </remarks>
[Typedef]
public readonly struct SDL_AudioFormat
{
	internal SDL_AudioFormat(ushort value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override readonly bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_AudioFormat cast)
		{
			return _value == cast._value;
		}
		return false;
	}

	/// <inheritdoc/>
	public override readonly int GetHashCode()
	{
		return _value.GetHashCode();
	}

	/// <summary>
	/// Gets the numerical value of an <see cref="SDL_AudioFormat"/> structure.
	/// </summary>
	/// <param name="x">The <see cref="SDL_AudioFormat"/> to convert.</param>
	public static explicit operator ushort(SDL_AudioFormat x) => x._value;

	/// <summary>
	/// Converts a 16-bit unsigned integer into an <see cref="SDL_AudioFormat"/> structure.
	/// </summary>
	/// <param name="x">The value to convert.</param>
	public static explicit operator SDL_AudioFormat(ushort x) => new(x);

	/// <summary>
	/// Compares if two <see cref="SDL_AudioFormat"/> structures have the same numerical value.
	/// </summary>
	/// <param name="a">The <see cref="SDL_AudioFormat"/> at the left side of the comparison.</param>
	/// <param name="b">The <see cref="SDL_AudioFormat"/> at the right side of the comparison.</param>
	/// <returns>True if both <paramref name="a"/> and <paramref name="b"/> are the same, false otherwise.</returns>
	public static bool operator ==(SDL_AudioFormat a, SDL_AudioFormat b) => a._value == b._value;

	/// <summary>
	/// Compares if two <see cref="SDL_AudioFormat"/> structures don't have the same numerical value.
	/// </summary>
	/// <param name="a">The <see cref="SDL_AudioFormat"/> at the left side of the comparison.</param>
	/// <param name="b">The <see cref="SDL_AudioFormat"/> at the right side of the comparison.</param>
	/// <returns>True if both <paramref name="a"/> and <paramref name="b"/> are not the same, false otherwise.</returns>
	public static bool operator !=(SDL_AudioFormat a, SDL_AudioFormat b) => a._value != b._value;

	private readonly ushort _value;
}