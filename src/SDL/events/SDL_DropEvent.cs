using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// An event used to drop text or request a file open by the system (<see cref="SDL_Event.Drop"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_DropEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_DropEvent
{
	/// <summary>
	/// Can be either <see cref="SDL_EventType.DropBegin"/>, <see cref="SDL_EventType.DropFile"/>, <see cref="SDL_EventType.DropText"/>, <see cref="SDL_EventType.DropComplete"/> or <see cref="SDL_EventType.DropPosition"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window that was dropped on, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// X coordinate, relative to window (not on begin).
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window (not on begin).
	/// </summary>
	public float Y;

	/// <summary>
	/// The source app that sent this drop event, or null if that isn't available.
	/// </summary>
	public readonly string? Source => Marshal.PtrToStringUTF8((nint)_source);

	private readonly byte* _source;

	/// <summary>
	/// The text for <see cref="SDL_EventType.DropText"/> and the file name for <see cref="SDL_EventType.DropFile"/>,
	/// null for other events
	/// </summary>
	public readonly string? Data => Marshal.PtrToStringUTF8((nint)_data);

	private readonly byte* _data;
}