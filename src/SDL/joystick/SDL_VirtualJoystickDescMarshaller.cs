using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

[CustomMarshaller(typeof(SDL_VirtualJoystickDesc), MarshalMode.ManagedToUnmanagedIn, typeof(SDL_VirtualJoystickDescMarshaller))]
public static unsafe class SDL_VirtualJoystickDescMarshaller
{
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_VirtualJoystickDescUnmanaged
	{
		public ushort type;
		public ushort padding;
		public ushort vendor_id;
		public ushort product_id;
		public ushort naxes;
		public ushort nbuttons;
		public ushort nballs;
		public ushort nhats;
		public ushort ntouchpads;
		public ushort nsensors;
		public ushort padding2;
		public ushort padding3;
		public uint button_mask;
		public uint axis_mask;
		public byte* name;
		public SDL_VirtualJoystickTouchpadDesc* touchpads;
		public SDL_VirtualJoystickSensorDesc* sensors;
		public nint userdata;
		public nint Update;
		public nint SetPlayerIndex;
		public nint Rumble;
		public nint RumbleTriggers;
		public nint SetLED;
		public nint SendEffect;
		public nint SetSensorsEnabled;
	}

	public static SDL_VirtualJoystickDescUnmanaged ConvertToUnmanaged(SDL_VirtualJoystickDesc managed)
	{
		SDL_VirtualJoystickDescUnmanaged unmanaged = new()
		{
			type = managed.Type,
			vendor_id = managed.VendorId,
			product_id = managed.ProductId,
			naxes = managed.NumAxes,
			nbuttons = managed.NumButtons,
			nballs = managed.NumBalls,
			nhats = managed.NumHats,
			ntouchpads = managed.NumTouchpads,
			nsensors = managed.NumSensors,
			button_mask = managed.ButtonMask,
			axis_mask = managed.AxisMask,
			name = Utf8StringMarshaller.ConvertToUnmanaged(managed.Name),
			touchpads = (SDL_VirtualJoystickTouchpadDesc*)Marshal.AllocHGlobal(sizeof(SDL_VirtualJoystickTouchpadDesc) * managed.NumTouchpads),
			sensors = (SDL_VirtualJoystickSensorDesc*)Marshal.AllocHGlobal(sizeof(SDL_VirtualJoystickSensorDesc) * managed.NumSensors),
			userdata = managed.UserData,
			Update = (managed.Update is not null) ? Marshal.GetFunctionPointerForDelegate(managed.Update) : nint.Zero,
			SetPlayerIndex = (managed.SetPlayerIndex is not null) ? Marshal.GetFunctionPointerForDelegate(managed.SetPlayerIndex) : nint.Zero,
			Rumble = (managed.Rumble is not null) ? Marshal.GetFunctionPointerForDelegate(managed.Rumble) : nint.Zero,
			RumbleTriggers = (managed.RumbleTriggers is not null) ? Marshal.GetFunctionPointerForDelegate(managed.RumbleTriggers) : nint.Zero,
			SetLED = (managed.SetLed is not null) ? Marshal.GetFunctionPointerForDelegate(managed.SetLed) : nint.Zero,
			SendEffect = (managed.SendEffect is not null) ? Marshal.GetFunctionPointerForDelegate(managed.SendEffect) : nint.Zero,
			SetSensorsEnabled = (managed.SetSensorsEnabled is not null) ? Marshal.GetFunctionPointerForDelegate(managed.SetSensorsEnabled) : nint.Zero,
		};
		for (int i = 0; i < managed.NumTouchpads; i++)
		{
			unmanaged.touchpads[i] = managed.Touchpads![i];
		}
		for (int i = 0; i < managed.NumSensors; i++)
		{
			unmanaged.sensors[i] = managed.Sensors![i];
		}
		return unmanaged;
	}

	public static void Free(SDL_VirtualJoystickDescUnmanaged unmanaged)
	{
		Utf8StringMarshaller.Free(unmanaged.name);
		Marshal.FreeHGlobal((nint)unmanaged.touchpads);
		Marshal.FreeHGlobal((nint)unmanaged.sensors);
	}
}