using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// This is a unique ID for a sensor for the time it is connected to the system, and is never reused for the
/// lifetime of the application.
/// </summary>
/// <remarks>
/// This structure is a wrapper for an unsigned 32-bit integer. Refer to the official
/// <see href="https://wiki.libsdl.org/SDL3/SDL_SensorID">documentation</see> for more details.
/// </remarks>
[Wrapper]
public readonly struct SDL_SensorId
{
	internal SDL_SensorId(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_SensorId cast)
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

	public static explicit operator uint(SDL_SensorId x) => x._value;

	public static explicit operator SDL_SensorId(uint x) => new(x);

	public static bool operator ==(SDL_SensorId a, SDL_SensorId b) => a._value == b._value;

	public static bool operator !=(SDL_SensorId a, SDL_SensorId b) => a._value != b._value;

	/// <summary>
	/// An invalid sensor ID. Used when a function that returns an <see cref="SDL_SensorId"/> fails.
	/// </summary>
	public static SDL_SensorId Invalid => new(0);

	private readonly uint _value;
}