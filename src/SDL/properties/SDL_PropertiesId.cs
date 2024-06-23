using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// SDL properties ID.
/// </summary>
/// <remarks>
/// This structure is a wrapper for an unsigned 32-bit integer. Refer to the official documentation
/// <see href="https://wiki.libsdl.org/SDL3/SDL_PropertiesID">here</see> for more details.
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

	public static explicit operator uint(SDL_PropertiesId x) => x._value;

	public static explicit operator SDL_PropertiesId(uint x) => new(x);

	public static bool operator ==(SDL_PropertiesId a, SDL_PropertiesId b) => a._value == b._value;

	public static bool operator !=(SDL_PropertiesId a, SDL_PropertiesId b) => a._value != b._value;

	/// <summary>
	/// An invalid set of properties. Used when a function that returns an <see cref="SDL_PropertiesId"/> fails or when
	/// you don't need/is not required to pass a set of properties to a function.
	/// </summary>
	public static SDL_PropertiesId Invalid => new(0);

	private readonly uint _value;
}