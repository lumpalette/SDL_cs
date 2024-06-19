using System;
using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Represents an audio format in numerical form and the collection of audio formats.
/// </summary>
/// <remarks>
/// <para>
/// All the available formats are defined as static properties that return <see cref="SDL_AudioFormat"/> structures.
/// The structure itself represents those formats.
/// </para>
/// <para>
/// The structure is a wrapper for an unsigned 32-bit integer. Refer to the official documentation
/// <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">here</see> for more details.
/// </para>
/// </remarks>
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

	public static explicit operator ushort(SDL_AudioFormat x) => x._value;

	public static explicit operator SDL_AudioFormat(ushort x) => new(x);

	public static bool operator ==(SDL_AudioFormat a, SDL_AudioFormat b) => a._value == b._value;

	public static bool operator !=(SDL_AudioFormat a, SDL_AudioFormat b) => a._value != b._value;

	/// <summary>
	/// Unsigned 8-bit samples.
	/// </summary>
	public static SDL_AudioFormat U8 => new(0x0008);

	/// <summary>
	/// Signed 8-bit samples.
	/// </summary>
	public static SDL_AudioFormat S8 => new(0x8008);

	/// <summary>
	/// Signed 16-bit samples, in little endian.
	/// </summary>
	public static SDL_AudioFormat S16LittleEndian => new(0x8010);

	/// <summary>
	/// Signed 16-bit samples, in big endian.
	/// </summary>
	public static SDL_AudioFormat S16BigEndian => new(0x9010);

	/// <summary>
	/// 32-bit integer samples, in little endian.
	/// </summary>
	public static SDL_AudioFormat S32LittleEndian => new(0x8020);

	/// <summary>
	/// 32-bit integer samples, in big endian.
	/// </summary>
	public static SDL_AudioFormat S32BigEndian => new(0x9020);

	/// <summary>
	/// 32-bit floating point samples, in little endian.
	/// </summary>
	public static SDL_AudioFormat F32LittleEndian => new(0x8120);

	/// <summary>
	/// 32-bit floating point samples, in big endian.
	/// </summary>
	public static SDL_AudioFormat F32BigEndian => new(0x9120);

	/// <summary>
	/// Signed 16-bit samples.
	/// </summary>
	public static SDL_AudioFormat S16 => BitConverter.IsLittleEndian ? S16LittleEndian : S16BigEndian;

	/// <summary>
	/// 32-bit integer samples.
	/// </summary>
	public static SDL_AudioFormat S32 => BitConverter.IsLittleEndian ? S32LittleEndian : S32BigEndian;

	/// <summary>
	/// 32-bit floating point samples.
	/// </summary>
	public static SDL_AudioFormat F32 => BitConverter.IsLittleEndian ? F32LittleEndian : F32BigEndian;

	private readonly ushort _value;
}