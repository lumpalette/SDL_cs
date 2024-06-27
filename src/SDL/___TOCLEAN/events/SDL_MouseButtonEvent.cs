using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Mouse button event structure (<see cref="SDL_Event.MouseButton"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MouseButtonEvent
{
	/// <summary>
	/// Can be either <see cref="SDL_EventType.MouseButtonDown"/> or <see cref="SDL_EventType.MouseButtonUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with mouse focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The mouse instance ID, <see cref="SDL.TouchMouseId"/>, or <see cref="SDL.PenMouseId"/>.
	/// </summary>
	public SDL_MouseId Which;

	/// <summary>
	/// The mouse button index.
	/// </summary>
	public byte Button;

	/// <summary>
	/// Can be either <see cref="SDL_InputState.Pressed"/> or <see cref="SDL_InputState.Released"/>.
	/// </summary>
	public SDL_InputState State;

	/// <summary>
	/// 1 for single-click, 2 for double-click, etc.
	/// </summary>
	public byte Clicks;

	private readonly byte _padding;

	/// <summary>
	/// X coordinate, relative to window.
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window.
	/// </summary>
	public float Y;
}