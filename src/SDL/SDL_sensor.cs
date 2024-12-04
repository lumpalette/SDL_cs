using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

// SDL_sensor.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_sensor.h.
namespace SDL3;

/// <summary>
/// The structure used to identify a sensor in SDL.
/// </summary>
[Opaque]
public unsafe struct SDL_Sensor;

/// <summary>
/// This is a unique ID for a sensor for the time it is connected to the system, and is never reused for the
/// lifetime of the application.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SensorID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_SensorId : uint
{
	/// <summary>
	/// An invalid/null sensor ID.
	/// </summary>
	Invalid = 0
}

/// <summary>
/// The different sensors defined by SDL.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SensorType">documentation</see> for more details.
/// </remarks>
public enum SDL_SensorType
{
	/// <summary>
	/// Returned for an invalid sensor.
	/// </summary>
	Invalid = -1,

	/// <summary>
	/// Unknown sensor type.
	/// </summary>
	Unknown,

	/// <summary>
	/// Accelerometer.
	/// </summary>
	Accelerometer,

	/// <summary>
	/// Gyroscope.
	/// </summary>
	Gyroscope,

	/// <summary>
	/// Accelerometer for left Joy-Con controller and Wii nunchuk.
	/// </summary>
	AccelerometerLeft,

	/// <summary>
	/// Gyroscope for left Joy-Con controller.
	/// </summary>
	GyroscopeLeft,

	/// <summary>
	/// Accelerometer for right Joy-Con controller.
	/// </summary>
	AccelerometerRight,

	/// <summary>
	/// Gyroscope for right Joy-Con controller.
	/// </summary>
	GyroscopeRight
}

unsafe partial class SDL
{
	/// <summary>
	/// A constant to represent standard gravity for accelerometer sensors.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_STANDARD_GRAVITY">documentation</see> for more details.
	/// </remarks>
	public const float StandardGravity = 9.80665f;

	/// <summary>
	/// Get a list of currently connected sensors.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensors">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of sensors returned, may be <see langword="null"/>.</param>
	/// <returns>A null-terminated array of sensor instance IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensors")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_SensorId* GetSensors(int* count);

	/// <summary>
	/// Get the implementation dependent name of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorNameForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The sensor instance ID.</param>
	/// <returns>The sensor name, or <see langword="null"/> if <paramref name="instanceId"/> is not valid.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorNameForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetSensorNameForId(SDL_SensorId instanceId);

	/// <summary>
	/// Get the type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorTypeForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The sensor instance ID.</param>
	/// <returns>The <see cref="SDL_SensorType"/>, or <see cref="SDL_SensorType.Invalid"/> if <paramref name="instanceId"/> is not valid.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorTypeForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_SensorType GetSensorTypeForId(SDL_SensorId instanceId);

	/// <summary>
	/// Get the platform dependent type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorNonPortableTypeForID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The sensor instance ID.</param>
	/// <returns>The sensor platform dependent type, or -1 if <paramref name="instanceId"/> is not valid.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorNonPortableTypeForID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetSensorNonPortableTypeForId(SDL_SensorId instanceId);

	/// <summary>
	/// Open a sensor for use.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenSensor">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The sensor instance ID.</param>
	/// <returns>An <see cref="SDL_Sensor"/> object or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_OpenSensor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Sensor* OpenSensor(SDL_SensorId instanceId);

	/// <summary>
	/// Return the <see cref="SDL_Sensor"/> associated with an instance ID.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorFromID">documentation</see> for more details.
	/// </remarks>
	/// <param name="instanceId">The sensor instance ID.</param>
	/// <returns>An <see cref="SDL_Sensor"/> object or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorFromID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Sensor* GetSensorFromId(SDL_SensorId instanceId);

	/// <summary>
	/// Get the properties associated with a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetSensorProperties(SDL_Sensor* sensor);

	/// <summary>
	/// Get the implementation dependent name of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorName">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object.</param>
	/// <returns>The sensor name or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetSensorName(SDL_Sensor* sensor);

	/// <summary>
	/// Get the type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorType">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object to inspect.</param>
	/// <returns>The <see cref="SDL_SensorType"/>, or <see cref="SDL_SensorType.Invalid"/> if <paramref name="sensor"/> is null.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorType")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_SensorType GetSensorType(SDL_Sensor* sensor);

	/// <summary>
	/// Get the platform dependent type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorNonPortableType">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object to inspect.</param>
	/// <returns>The sensor platform dependent type, or -1 if <paramref name="sensor"/> is <see langword="null"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorNonPortableType")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetSensorNonPortableType(SDL_Sensor* sensor);

	/// <summary>
	/// Get the instance ID of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorID">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object to inspect.</param>
	/// <returns>The sensor instance ID or <see cref="SDL_SensorId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorID")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_SensorId GetSensorId(SDL_Sensor* sensor);

	/// <summary>
	/// Get the current state of an opened sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorData">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object to query. </param>
	/// <param name="data">A pointer filled with the current sensor state.</param>
	/// <param name="numValues">The number of values to write to data.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorData")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetSensorData(SDL_Sensor* sensor, float* data, int numValues);

	/// <summary>
	/// Close a sensor previously opened with <see cref="OpenSensor(SDL_SensorId)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CloseSensor">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object to close.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CloseSensor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void CloseSensor(SDL_Sensor* sensor);

	/// <summary>
	/// Update the current state of the open sensors.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateSensors">documentation</see> for more details.
	/// </remarks>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateSensors")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void UpdateSensors();
}