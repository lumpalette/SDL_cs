using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Pressure-sensitive pen motion / pressure / angle event structure (<see cref="SDL_Event.PenMotion"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PenMotionEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_PenMotionEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.PenMotion"/>.
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

	private readonly byte _padding1;

	private readonly byte _padding2;

	public ushort PenState;

	public float X;

	public float Y;

	private fixed float _axes[6];
}