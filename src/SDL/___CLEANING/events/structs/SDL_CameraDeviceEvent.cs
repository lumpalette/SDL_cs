using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Camera device event structure (<see cref="SDL_Event.CameraDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CameraDeviceEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_CameraDeviceEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.CameraDeviceAdded"/>, <see cref="SDL_EventType.CameraDeviceRemoved"/>,
	/// <see cref="SDL_EventType.CameraDeviceApproved"/> or <see cref="SDL_EventType.CameraDeviceDenied"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// <see cref="FIXME:SDL_CameraID"/> for the device being added or removed or changing
	/// </summary>
	public uint Which; // FIXME: implement SDL_camera.h
}