using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Represents a unique ID for a touch device.
/// </summary>
/// <remarks>
/// The structure is a wrapper for an unsigned 64-bit integer.
/// </remarks>
[Wrapper]
public readonly struct SDL_TouchId
{
	internal SDL_TouchId(ulong value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_TouchId cast)
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
	/// An invalid touch device ID. Used when a function that returns an <see cref="SDL_TouchId"/> fails.
	/// </summary>
	public static SDL_TouchId Invalid => new();

	public static explicit operator ulong(SDL_TouchId x) => x._value;

	public static explicit operator SDL_TouchId(ulong x) => new(x);

	public static bool operator ==(SDL_TouchId a, SDL_TouchId b) => a._value == b._value;

	public static bool operator !=(SDL_TouchId a, SDL_TouchId b) => a._value != b._value;

	private readonly ulong _value;
}