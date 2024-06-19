using System.Runtime.InteropServices;

namespace SDL_cs;

// FIXME: write the SDL_camera.h binding.

/// <summary>
/// Camera device event structure (FIXME:event.cdevice.*).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CameraDeviceEvent">here</see>.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_CameraDeviceEvent
{
	/// <summary>
	/// Can be either <see cref="SDL_EventType.CameraDeviceAdded"/>, <see cref="SDL_EventType.CameraDeviceRemoved"/>, <see cref="SDL_EventType.CameraDeviceApproved"/> or <see cref="SDL_EventType.CameraDeviceDenied"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// <see cref="FIXME:SDL_CameraDeviceId"/> for the device being added or removed or changing
	/// </summary>
	public uint Which;
}