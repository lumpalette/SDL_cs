using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Represents the ID of a window.
/// </summary>
/// <remarks>
/// The structure is a wrapper for an unsigned 32-bit integer.
/// </remarks>
[Wrapper]
public readonly struct SDL_WindowId
{
	internal SDL_WindowId(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_WindowId cast)
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

	public static explicit operator uint(SDL_WindowId x) => x._value;
	
	public static explicit operator SDL_WindowId(uint x) => new(x);

	public static bool operator ==(SDL_WindowId a, SDL_WindowId b) => a._value == b._value;
	
	public static bool operator !=(SDL_WindowId a, SDL_WindowId b) => a._value != b._value;

	/// <summary>
	/// An invalid ID for a window. Used when a function that returns an <see cref="SDL_WindowId"/> fails.
	/// </summary>
	public static SDL_WindowId Invalid => new(0);

	private readonly uint _value;
}