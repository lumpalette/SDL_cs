using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Pressure-sensitive pen motion/pressure/angle event structure (<see cref="SDL_Event.PenMotion"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PenMotionEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_PenMotionEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.PenMotion"/>.
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

	/// <summary>
	/// The pen instance ID.
	/// </summary>
	public SDL_PenId Which;

	private readonly byte _padding1;

	private readonly byte _padding2;

	/// <summary>
	/// Pen button masks. <see cref="SDL_PenCapabilityFlags.Down"/> is set if the pen is touching the surface, and
	/// <see cref="SDL_PenCapabilityFlags.Eraser"/> is set if the pen is (used as) an eraser.
	/// </summary>
	public ushort PenState;

	/// <summary>
	/// X coordinate, relative to window.
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window.
	/// </summary>
	public float Y;

	/// <summary>
	/// Pen axes such as pressure and tilt (ordered as per <see cref="SDL_PenAxis"/>).
	/// </summary>
	public fixed float Axes[(int)SDL_PenAxis.NumAxes];
}