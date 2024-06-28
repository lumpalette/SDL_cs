using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Represents a unique ID for a finger.
/// </summary>
/// <remarks>
/// This structure is a wrapper for an unsigned 64-bit integer.
/// </remarks>
[Typedef]
public readonly struct SDL_FingerId
{
	internal SDL_FingerId(ulong value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_FingerId cast)
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

	public static explicit operator ulong(SDL_FingerId x) => x._value;

	public static explicit operator SDL_FingerId(ulong x) => new(x);

	public static bool operator ==(SDL_FingerId a, SDL_FingerId b) => a._value == b._value;

	public static bool operator !=(SDL_FingerId a, SDL_FingerId b) => a._value != b._value;

	private readonly ulong _value;
}