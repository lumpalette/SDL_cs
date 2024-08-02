using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Pressure-sensitive pen touched or stopped touching surface (<see cref="SDL_Event.PenTip"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PenTipEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_PenTipEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.PenDown"/> or <see cref="SDL_EventType.PenUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with pen focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	public uint Which;

	public byte Tip;

	public byte State;

	public ushort PenState;

	public float X;

	public float Y;

	private fixed float _axes[6];
}