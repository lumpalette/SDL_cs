using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class SDL_PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_SensorId* SDL_GetSensors(int* count);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetSensorInstanceName(SDL_SensorId sensorId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_SensorType SDL_GetSensorInstanceType(SDL_SensorId sensorId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetSensorInstanceNonPortableType(SDL_SensorId sensorId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Sensor* SDL_OpenSensor(SDL_SensorId sensorId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Sensor* SDL_GetSensorFromInstanceID(SDL_SensorId sensorId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_PropertiesId SDL_GetSensorProperties(SDL_Sensor* sensor);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetSensorName(SDL_Sensor* sensor);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_SensorType SDL_GetSensorType(SDL_Sensor* sensor);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetSensorNonPortableType(SDL_Sensor* sensor);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_SensorId SDL_GetSensorInstanceID(SDL_Sensor* sensor);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetSensorData(SDL_Sensor* sensor, float* data, int numValues);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_CloseSensor(SDL_Sensor* sensor);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_UpdateSensors();
}