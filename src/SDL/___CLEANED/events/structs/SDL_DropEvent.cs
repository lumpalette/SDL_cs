using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

/// <summary>
/// An event used to drop text or request a file open by the system (<see cref="SDL_Event.Drop"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DropEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_DropEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.DropBegin"/>, <see cref="SDL_EventType.DropFile"/>,
	/// <see cref="SDL_EventType.DropText"/>, <see cref="SDL_EventType.DropComplete"/> or
	/// <see cref="SDL_EventType.DropPosition"/>.
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
	/// The source app that sent this drop event, or <see langword="null"/> if that isn't available.
	/// </summary>
	public readonly byte* SourceRaw;

	/// <summary>
	/// The source app that sent this drop event, or <see langword="null"/> if that isn't available.
	/// </summary>
	public readonly string? Source => Utf8StringMarshaller.ConvertToManaged(SourceRaw);

	/// <summary>
	/// The text for <see cref="SDL_EventType.DropText"/> and the file name for <see cref="SDL_EventType.DropFile"/>,
	/// <see langword="null"/> for other events.
	/// </summary>
	public readonly byte* DataRaw;

	/// <summary>
	/// The text for <see cref="SDL_EventType.DropText"/> and the file name for <see cref="SDL_EventType.DropFile"/>,
	/// <see langword="null"/> for other events.
	/// </summary>
	public readonly string? Data => Utf8StringMarshaller.ConvertToManaged(DataRaw);
}