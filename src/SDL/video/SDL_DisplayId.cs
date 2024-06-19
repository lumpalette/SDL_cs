using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Represents the ID for a display.
/// </summary>
/// <remarks>
/// The structure is a wrapper for an unsigned 32-bit integer.
/// </remarks>
[Wrapper]
public readonly struct SDL_DisplayId
{
	internal SDL_DisplayId(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_DisplayId cast)
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

	public static explicit operator uint(SDL_DisplayId x) => x._value;

	public static explicit operator SDL_DisplayId(uint x) => new(x);

	public static bool operator ==(SDL_DisplayId a, SDL_DisplayId b) => a._value == b._value;

	public static bool operator !=(SDL_DisplayId a, SDL_DisplayId b) => a._value != b._value;

	/// <summary>
	/// An invalid ID for a display. Used when a function that returns an <see cref="SDL_DisplayId"/> fails.
	/// </summary>
	public static SDL_DisplayId Invalid => new(0);

	private readonly uint _value;
}