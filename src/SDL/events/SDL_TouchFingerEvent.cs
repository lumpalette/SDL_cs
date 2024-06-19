using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Touch finger event structure (FIXME:event.tfinger.*).
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_TouchFingerEvent
{
	/// <summary>
	/// Can be either <see cref="SDL_EventType.FingerMotion"/>, <see cref="SDL_EventType.FingerUp"/> or <see cref="SDL_EventType.FingerDown"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
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