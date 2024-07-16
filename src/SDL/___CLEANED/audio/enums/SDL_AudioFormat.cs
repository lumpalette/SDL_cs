namespace SDL_cs;

/// <summary>
/// Audio format flags.
/// </summary>
/// <remarks>
/// <para>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
/// </para>
/// <para>
/// For audio formats based on the system's endianness, use <see cref="SDL.AudioFormatS16"/>, <see cref="SDL.AudioFormatS32"/>
/// and <see cref="SDL.AudioFormatF32"/> respectively.
/// </para>
/// </remarks>
[Typedef]
public enum SDL_AudioFormat
{
	/// <summary>
	/// Unsigned 8-bit samples.
	/// </summary>
	U8 = 0x0008,

	/// <summary>
	/// Signed 8-bit samples.
	/// </summary>
	S8 = 0x8008,

	/// <summary>
	/// Signed 16-bit samples, in little endian.
	/// </summary>
	S16LittleEndian = 0x8010,

	/// <summary>
	/// Signed 16-bit samples, in big endian.
	/// </summary>
	S16BigEndian = 0x9010,

	/// <summary>
	/// 32-bit integer samples, in little endian.
	/// </summary>
	S32LittleEndian = 0x8020,

	/// <summary>
	/// 32-bit integer samples, in big endian.
	/// </summary>
	S32BigEndian = 0x9020,

	/// <summary>
	/// 32-bit floating point samples, in little endian.
	/// </summary>
	F32LittleEndian = 0x8120,

	/// <summary>
	/// 32-bit floating point samples, in big endian.
	/// </summary>
	F32BigEndian = 0x9120
}