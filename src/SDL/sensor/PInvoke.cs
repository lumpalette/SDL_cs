using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_sensor.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_sensor.h.
unsafe partial class SDL
{
	/// <summary>
	/// Get a list of currently connected sensors.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensors">here</see>.
	/// </remarks>
	/// <param name="count"> Returns the number of sensors. </param>
	/// <returns> An array of sensor instance ids, or null on error; call <see cref="GetError"/> for more details. </returns>
	public static SDL_SensorId[]? GetSensors(out int count)
	{
		fixed (int* c = &count)
		{
			SDL_SensorId* s = _PInvoke(c);
			if (s is null)
			{
				return null;
			}
			SDL_SensorId[] sensors = new SDL_SensorId[count];
			for (int i = 0; i < count; i++)
			{
				sensors[i] = s[i];
			}
			Free(s);
			return sensors;
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSensors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_SensorId* _PInvoke(int* count);
	}

	/// <summary>
	/// Get the implementation dependent name of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorInstanceName">here</see>.
	/// </remarks>
	/// <param name="sensorId"> The sensor instance ID. </param>
	/// <returns> The sensor name, or null if <paramref name="sensorId"/> is not valid. </returns>
	public static string? GetSensorInstanceName(SDL_SensorId sensorId)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(sensorId));

		[DllImport(LibraryName, EntryPoint = "SDL_GetSensorInstanceName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_SensorId sensorId);
	}

	/// <summary>
	/// Get the type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorInstanceType">here</see>.
	/// </remarks>
	/// <param name="sensorId"> The sensor instance ID. </param>
	/// <returns> The <see cref="SDL_SensorType"/>, or <see cref="SDL_SensorType.Invalid"/> if <paramref name="sensorId"/> is not valid. </returns>
	public static SDL_SensorType GetSensorInstanceType(SDL_SensorId sensorId)
	{
		return _PInvoke(sensorId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetSensorInstanceType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_SensorType _PInvoke(SDL_SensorId sensorId);
	}

	/// <summary>
	/// Get the platform dependent type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorInstanceNonPortableType">here</see>.
	/// </remarks>
	/// <param name="sensorId"> The sensor instance ID. </param>
	/// <returns> The sensor platform dependent type, or -1 if <paramref name="sensorId"/> is not valid. </returns>
	public static int GetSensorInstanceNonPortableType(SDL_SensorId sensorId)
	{
		return _PInvoke(sensorId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetSensorInstanceNonPortableType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_SensorId sensorId);
	}

	/// <summary>
	/// Open a sensor for use.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_OpenSensor">here</see>.
	/// </remarks>
	/// <param name="sensorId"> The sensor instance ID. </param>
	/// <returns> An <see cref="SDL_Sensor"/> object, or null if an error occurred. </returns>
	public static SDL_Sensor* OpenSensor(SDL_SensorId sensorId)
	{
		return _PInvoke(sensorId);

		[DllImport(LibraryName, EntryPoint = "SDL_OpenSensor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Sensor* _PInvoke(SDL_SensorId sensorId);
	}

	/// <summary>
	/// Return the <see cref="SDL_Sensor"/> associated with an instance ID.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorFromInstanceID">here</see>.
	/// </remarks>
	/// <param name="sensorId"> The sensor instance ID. </param>
	/// <returns> An <see cref="SDL_Sensor"/> object. </returns>
	public static SDL_Sensor* GetSensorFromInstanceId(SDL_SensorId sensorId)
	{
		return _PInvoke(sensorId);

		[DllImport(LibraryName, EntryPoint = "SDL_GetSensorFromInstanceID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Sensor* _PInvoke(SDL_SensorId sensorId);
	}

	/// <summary>
	/// Get the properties associated with a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorProperties">here</see>.
	/// </remarks>
	/// <param name="sensor"> The <see cref="SDL_Sensor"/> object to query. </param>
	/// <returns> A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetSensorProperties(SDL_Sensor* sensor)
	{
		return _PInvoke(sensor);

		[DllImport(LibraryName, EntryPoint = "SDL_GetSensorProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PropertiesId _PInvoke(SDL_Sensor* sensor);
	}

	/// <summary>
	/// Get the implementation dependent name of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorName">here</see>.
	/// </remarks>
	/// <param name="sensor"> The <see cref="SDL_Sensor"/> object to query. </param>
	/// <returns> The sensor name, or null if <paramref name="sensor"/> is null. </returns>
	public static string? GetSensorName(SDL_Sensor* sensor)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(sensor));

		[DllImport(LibraryName, EntryPoint = "SDL_GetSensorName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Sensor* sensor);
	}

	/// <summary>
	/// Get the type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorType">here</see>.
	/// </remarks>
	/// <param name="sensor"> The <see cref="SDL_Sensor"/> object to query. </param>
	/// <returns> The <see cref="SDL_SensorType"/>, or <see cref="SDL_SensorType.Invalid"/> if <paramref name="sensor"/> is null. </returns>
	public static SDL_SensorType GetSensorType(SDL_Sensor* sensor)
	{
		return _PInvoke(sensor);

		[DllImport(LibraryName, EntryPoint = "SDL_GetSensorType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_SensorType _PInvoke(SDL_Sensor* sensor);
	}

	/// <summary>
	/// Get the platform dependent type of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorNonPortableType">here</see>.
	/// </remarks>
	/// <param name="sensor"> The <see cref="SDL_Sensor"/> object to query. </param>
	/// <returns> The sensor platform dependent type, or -1 if <paramref name="sensor"/> is null. </returns>
	public static int GetSensorNonPortableType(SDL_Sensor* sensor)
	{
		return _PInvoke(sensor);

		[DllImport(LibraryName, EntryPoint = "SDL_GetSensorNonPortableType", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Sensor* sensor);
	}

	/// <summary>
	/// Get the instance ID of a sensor.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSensorInstanceID">here</see>.
	/// </remarks>
	/// <param name="sensor"> The <see cref="SDL_Sensor"/> object to query. </param>
	/// <returns> The sensor instance ID, or <see cref="SDL_SensorId.Invalid"/> if <paramref name="sensor"/> is null. </returns>
	public static SDL_SensorId GetSensorInstanceId(SDL_Sensor* sensor)
	{
		return _PInvoke(sensor);

		[DllImport(LibraryName, EntryPoint = "SDL_GetSensorInstanceID", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_SensorId _PInvoke(SDL_Sensor* sensor);
	}

	// ADDME:SDL_GetSensorData

	/// <summary>
	/// Close a sensor previously opened with <see cref="OpenSensor(SDL_SensorId)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CloseSensor">here</see>.
	/// </remarks>
	/// <param name="sensor"> The <see cref="Sensor"/> object to close. </param>
	public static void CloseSensor(SDL_Sensor* sensor)
	{
		_PInvoke(sensor);

		[DllImport(LibraryName, EntryPoint = "SDL_CloseSensor", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_Sensor* sensor);
	}

	/// <summary>
	/// Update the current state of the open sensors.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateSensors">here</see>.
	/// </remarks>
	public static void UpdateSensors()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateSensors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke();
	}

	/// <summary>
	/// A constant to represent standard gravity for accelerometer sensors.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_STANDARD_GRAVITY">here</see>.
	/// </remarks>
	public const float StandardGravity = 9.80665f;
}