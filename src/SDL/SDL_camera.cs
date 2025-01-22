using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

// SDL_camera.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_camera.h.
namespace SDL3;

/// <summary>
/// This is a unique ID for a camera device for the time it is connected to the system, and is never reused
/// for the lifetime of the application.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CameraId">documentation</see> for more details.
/// </remarks>
public enum SDL_CameraId : uint
{
	/// <summary>
	/// An invalid/null camera device ID.
	/// </summary>
	Invalid = 0
}

/// <summary>
/// The opaque structure used to identify an opened SDL camera.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Camera">documentation</see> for more details.
/// </remarks>
public unsafe struct SDL_Camera;

/// <summary>
/// The details of an output format for a camera device.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CameraSpec">documentation</see> for more details.
/// </remarks>
public struct SDL_CameraSpec
{
	/// <summary>
	/// Frame format.
	/// </summary>
	public SDL_PixelFormat Format;

	/// <summary>
	/// Frame colorspace.
	/// </summary>
	public SDL_Colorspace Colorspace;

	/// <summary>
	/// Frame width.
	/// </summary>
	public int Width;

	/// <summary>
	/// Frame height;
	/// </summary>
	public int Height;

	/// <summary>
	/// Frame rate numerator ((num / denom) == FPS, (denom / num) == duration in seconds).
	/// </summary>
	public int FramerateNumerator;

	/// <summary>
	/// Frame rate demoninator ((num / denom) == FPS, (denom / num) == duration in seconds).
	/// </summary>
	public int FramerateDenominator;
}

/// <summary>
/// The position of camera in relation to system device.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CameraPosition">documentation</see> for more details.
/// </remarks>
public enum SDL_CameraPosition
{
	/// <summary>
	/// The position cannot be determined.
	/// </summary>
	Unknown,

	/// <summary>
	/// The camera is at the front of the device.
	/// </summary>
	FrontFacing,

	/// <summary>
	/// The camera is at the back of the device.
	/// </summary>
	BackFacing
}

unsafe partial class SDL
{
	/// <summary>
	/// Use this function to get the number of built-in camera drivers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumCameraDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns>The number of built-in camera drivers.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumCameraDrivers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumCameraDrivers();

	/// <summary>
	/// Use this function to get the name of a built in camera driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCameraDriver">documentation</see> for more details.
	/// </remarks>
	/// <param name="index">The index of the camera driver; the value ranges from 0 to <see cref="GetNumCameraDrivers"/> - 1.</param>
	/// <returns>The name of the camera driver at the requested index, or <see langword="null"/> if an invalid index was specified.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraDriver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetCameraDriver(int index);

	/// <summary>
	/// Get the name of the current camera driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentCameraDriver">documentation</see> for more details.
	/// </remarks>
	/// <returns>The name of the current camera driver or <see langword="null"/> if no driver has been initialized.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentCameraDriver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetCurrentCameraDriver();

	/// <summary>
	/// Get a list of currently connected camera devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCameras">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of cameras returned, may be <see langword="null"/>.</param>
	/// <returns>A null-terminated array of camera instance IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCameras")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_CameraId* GetCameras(int* count);

	/// <summary>
	/// Get the list of native formats/sizes a camera supports.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCameraSupportedFormats">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The camera device instance ID to query.</param>
	/// <param name="count">A pointer filled in with the number of elements in the list, may be <see langword="null"/>.</param>
	/// <returns>A null-terminated array of pointers to <see cref="SDL_CameraSpec"/> or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This is a single allocation that should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraSupportedFormats")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_CameraSpec** GetCameraSupportedFormats(SDL_CameraId devId, int* count);

	/// <summary>
	/// Get the human-readable device name for a camera.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCameraName">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The camera device instance ID.</param>
	/// <returns>A human-readable device name or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetCameraName(SDL_CameraId instanceId);

	/// <summary>
	/// Get the position of the camera in relation to the system.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCameraPosition">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The camera device instance ID.</param>
	/// <returns>The position of the camera on the system hardware.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraPosition")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_CameraPosition GetCameraPosition(SDL_CameraId instanceId);

	/// <summary>
	/// Open a video recording device (a "camera").
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenCamera">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The camera device instance ID.</param>
	/// <param name="spec">The desired format for data the device will provide. Can be <see langword="null"/>.</param>
	/// <returns>An <see cref="SDL_Camera"/> object or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_OpenCamera")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Camera* OpenCamera(SDL_CameraId instanceId, [Const] SDL_CameraSpec* spec);

	/// <summary>
	/// Query if camera access has been approved by the user.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCameraPermissionState">documentation</see> for more details.
	/// </remarks>
	/// <param name="camera">The opened camera device to query.</param>
	/// <returns>-1 if user denied access to the camera, 1 if user approved access, 0 if no decision has been made yet.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraPermissionState")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetCameraPermissionState(SDL_Camera* camera);

	/// <summary>
	/// Get the instance ID of an opened camera.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCameraID">documentation</see> for more details.
	/// </remarks>
	/// <param name="camera">An <see cref="SDL_Camera"/> to query.</param>
	/// <returns>The instance ID of the specified camera on success or <see cref="SDL_CameraId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_CameraId GetCameraId(SDL_Camera* camera);

	/// <summary>
	/// Get the properties associated with an opened camera.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCameraProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="camera">The <see cref="SDL_Camera"/> obtained from <see cref="OpenCamera(SDL_CameraId, SDL_CameraSpec*)"/>.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_CameraId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetCameraProperties(SDL_Camera* camera);

	/// <summary>
	/// Get the spec that a camera is using when generating images.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCameraFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="camera">Opened camera device.</param>
	/// <param name="spec">The <see cref="SDL_CameraSpec"/> to be initialized by this function.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(BoolSize)]
	public static partial bool GetCameraFormat(SDL_Camera* camera, SDL_CameraSpec* spec);

	/// <summary>
	/// Acquire a frame.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AcquireCameraFrame">documentation</see> for more details.
	/// </remarks>
	/// <param name="camera">Opened camera device.</param>
	/// <param name="timestampNs">A pointer filled in with the frame's timestamp, or 0 on  error. Can be <see langword="null"/>.</param>
	/// <returns>A new frame of video on success, <see langword="null"/> if none is currently available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AcquireCameraFrame")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface* AcquireCameraFrame(SDL_Camera* camera, ulong* timestampNs);

	/// <summary>
	/// Release a frame of video acquired from a camera.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ReleaseCameraFrame">documentation</see> for more details.
	/// </remarks>
	/// <param name="camera">Opened camera device.</param>
	/// <param name="frame">The video frame surface to release.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseCameraFrame")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void ReleaseCameraFrame(SDL_Camera* camera, SDL_Surface* frame);

	/// <summary>
	/// Use this function to shut down camera processing and close the camera device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CloseCamera">documentation</see> for more details.
	/// </remarks>
	/// <param name="camera">Opened camera device.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CloseCamera")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void CloseCamera(SDL_Camera* camera);
}