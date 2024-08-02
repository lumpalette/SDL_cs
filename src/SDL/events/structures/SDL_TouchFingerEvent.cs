using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Touch finger event structure (<see cref="SDL_Event.TouchFinger"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TouchFingerEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_TouchFingerEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.FingerMotion"/>, <see cref="SDL_EventType.FingerDown"/> or
	/// <see cref="SDL_EventType.FingerUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The touch device ID.
	/// </summary>
	public SDL_TouchId TouchId;

	/// <summary>
	/// The finger ID.
	/// </summary>
	public SDL_FingerId FingerId;

	/// <summary>
	/// Normalized in the range 0...1.
	/// </summary>
	public float X;

	/// <summary>
	/// Normalized in the range 0...1.
	/// </summary>
	public float Y;

	/// <summary>
	/// Normalized in the range -1...1.
	/// </summary>
	public float Dx;

	/// <summary>
	/// Normalized in the range -1...1.
	/// </summary>
	public float Dy;

	/// <summary>
	/// Normalized in the range 0...1.
	/// </summary>
	public float Pressure;

	/// <summary>
	/// The window underneath the finger, if any.
	/// </summary>
	public SDL_WindowId WindowId;
}