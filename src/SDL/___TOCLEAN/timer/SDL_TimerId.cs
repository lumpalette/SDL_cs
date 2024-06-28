using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Definition of the timer ID type.
/// </summary>
/// <remarks>
/// This structure is a wrapper for a 32-bit unsigned integer. Refer to the official
/// <see href="https://wiki.libsdl.org/SDL3/SDL_TimerID">documentation</see> for more details.
/// </remarks>
[Typedef]
public readonly struct SDL_TimerId
{
	internal SDL_TimerId(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_TimerId cast)
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

	public static explicit operator uint(SDL_TimerId x) => x._value;

	public static explicit operator SDL_TimerId(uint x) => new(x);

	public static bool operator ==(SDL_TimerId a, SDL_TimerId b) => a._value == b._value;

	public static bool operator !=(SDL_TimerId a, SDL_TimerId b) => a._value != b._value;

	private readonly uint _value;
}