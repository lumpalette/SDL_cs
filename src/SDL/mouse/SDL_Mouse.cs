using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Represents a unique ID for a mouse.
/// </summary>
/// <remarks>
/// The structure is a wrapper for an unsigned 32-bit integer.
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

	public static explicit operator uint(SDL_MouseId x) => x._value;

	public static explicit operator SDL_MouseId(uint x) => new(x);

	public static bool operator ==(SDL_MouseId a, SDL_MouseId b) => a._value == b._value;

	public static bool operator !=(SDL_MouseId a, SDL_MouseId b) => a._value != b._value;

	private readonly uint _value;
}