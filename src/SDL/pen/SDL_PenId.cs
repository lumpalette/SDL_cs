using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// SDL pen instance IDs.
/// </summary>
/// <remarks>
/// This structure is a wrapper for an unsigned 32-bit integer.
/// </remarks>
[Wrapper]
public readonly struct SDL_PenId
{
	internal SDL_PenId(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_PenId cast)
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

	public static explicit operator uint(SDL_PenId x) => x._value;

	public static explicit operator SDL_PenId(uint x) => new(x);

	public static bool operator ==(SDL_PenId a, SDL_PenId b) => a._value == b._value;

	public static bool operator !=(SDL_PenId a, SDL_PenId b) => a._value != b._value;

	/// <summary>
	/// An invalid pen ID. Used when a function that returns an <see cref="SDL_PenId"/> fails.
	/// </summary>
	public static SDL_PenId Invalid => new(0);

	private readonly uint _value;
}