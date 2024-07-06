using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_sensor.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_sensor.h.
unsafe partial class SDL
{
	/// <summary>
	/// Get a list of currently connected sensors.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensors">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">The number of sensors returned.</param>
	/// <returns>An array of sensor instance IDs, or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	public static SDL_SensorId[]? GetSensors(out int count)
	{
		fixed (int* countPtr = &count)
		{
			var s = PInvoke.SDL_GetSensors(countPtr);
			if (s is null)
			{
				return null;
			}
			var sensors = new SDL_SensorId[count];
			for (int i = 0; i < count; i++)
			{
				sensors[i] = s[i];
			}
			Free(s);
			return sensors;
		}
	}

	/// <summary>
	/// Get the implementation dependent name of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorInstanceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensorId">The sensor instance ID.</param>
	/// <returns>The sensor name, or <see langword="null"/> if <paramref name="sensorId"/> is not valid.</returns>
	public static string? GetSensorInstanceName(SDL_SensorId sensorId)
	{
		return Marshal.PtrToStringUTF8((nint)PInvoke.SDL_GetSensorInstanceName(sensorId));
	}

	/// <summary>
	/// Get the type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorInstanceType">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensorId">The sensor instance ID.</param>
	/// <returns>The <see cref="SDL_SensorType"/>, or <see cref="SDL_SensorType.Invalid"/> if <paramref name="sensorId"/> is not valid.</returns>
	public static SDL_SensorType GetSensorInstanceType(SDL_SensorId sensorId)
	{
		return PInvoke.SDL_GetSensorInstanceType(sensorId);
	}

	/// <summary>
	/// Get the platform dependent type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorInstanceNonPortableType">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensorId">The sensor instance ID.</param>
	/// <returns>The sensor platform dependent type, or -1 if <paramref name="sensorId"/> is not valid.</returns>
	public static int GetSensorInstanceNonPortableType(SDL_SensorId sensorId)
	{
		return PInvoke.SDL_GetSensorInstanceNonPortableType(sensorId);
	}

	/// <summary>
	/// Open a sensor for use.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenSensor">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensorId">The sensor instance ID.</param>
	/// <returns>An <see cref="SDL_Sensor"/> object, or <see langword="null"/> if an error occurred.</returns>
	public static SDL_Sensor* OpenSensor(SDL_SensorId sensorId)
	{
		return PInvoke.SDL_OpenSensor(sensorId);
	}

	/// <summary>
	/// Return the <see cref="SDL_Sensor"/> associated with an instance ID.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorFromInstanceID">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensorId">The sensor instance ID.</param>
	/// <returns>An <see cref="SDL_Sensor"/> object.</returns>
	public static SDL_Sensor* GetSensorFromInstanceId(SDL_SensorId sensorId)
	{
		return PInvoke.SDL_GetSensorFromInstanceID(sensorId);
	}

	/// <summary>
	/// Get the properties associated with a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	public static SDL_PropertiesId GetSensorProperties(SDL_Sensor* sensor)
	{
		return PInvoke.SDL_GetSensorProperties(sensor);
	}

	/// <summary>
	/// Get the implementation dependent name of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorName">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object.</param>
	/// <returns>The sensor name, or <see langword="null"/> if <paramref name="sensor"/> is <see langword="null"/>.</returns>
	public static string? GetSensorName(SDL_Sensor* sensor)
	{
		return Marshal.PtrToStringUTF8((nint)PInvoke.SDL_GetSensorName(sensor));
	}

	/// <summary>
	/// Get the type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorType">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object to inspect.</param>
	/// <returns>The <see cref="SDL_SensorType"/>, or <see cref="SDL_SensorType.Invalid"/> if <paramref name="sensor"/> is null.</returns>
	public static SDL_SensorType GetSensorType(SDL_Sensor* sensor)
	{
		return PInvoke.SDL_GetSensorType(sensor);
	}

	/// <summary>
	/// Get the platform dependent type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorNonPortableType">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object to inspect.</param>
	/// <returns>The sensor platform dependent type, or -1 if <paramref name="sensor"/> is <see langword="null"/>.</returns>
	public static int GetSensorNonPortableType(SDL_Sensor* sensor)
	{
		return PInvoke.SDL_GetSensorNonPortableType(sensor);
	}

	/// <summary>
	/// Get the instance ID of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorInstanceID">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object to inspect.</param>
	/// <returns>The sensor instance ID, or <see cref="SDL_SensorId.Invalid"/> if <paramref name="sensor"/> is <see langword="null"/>.</returns>
	public static SDL_SensorId GetSensorInstanceId(SDL_Sensor* sensor)
	{
		return PInvoke.SDL_GetSensorInstanceID(sensor);
	}

	/// <summary>
	/// Get the current state of an opened sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorData">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object to query. </param>
	/// <param name="data">The current sensor state. The length of the array matches the number of values to query.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GetSensorData(SDL_Sensor* sensor, ref float[] data)
	{
		fixed (float* dataPtr = data)
		{
			return PInvoke.SDL_GetSensorData(sensor, dataPtr, data.Length);
		}
	}

	/// <summary>
	/// Close a sensor previously opened with <see cref="OpenSensor(SDL_SensorId)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CloseSensor">documentation</see> for more details.
	/// </remarks>
	/// <param name="sensor">The <see cref="SDL_Sensor"/> object to close.</param>
	public static void CloseSensor(SDL_Sensor* sensor)
	{
		PInvoke.SDL_CloseSensor(sensor);
	}

	/// <summary>
	/// Update the current state of the open sensors.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateSensors">documentation</see> for more details.
	/// </remarks>
	public static void UpdateSensors()
	{
		PInvoke.SDL_UpdateSensors();
	}

	/// <summary>
	/// A constant to represent standard gravity for accelerometer sensors.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_STANDARD_GRAVITY">documentation</see> for more details.
	/// </remarks>
	public const float StandardGravity = 9.80665f;
}