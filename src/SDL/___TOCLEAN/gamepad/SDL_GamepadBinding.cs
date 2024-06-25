using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A mapping between one joystick input to a gamepad control.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadBinding">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadBinding
{
	public SDL_GamepadType InputType;

	public InputData Input;

	public SDL_GamepadType OutputType;

	public OutputData Output;

	[Union, StructLayout(LayoutKind.Explicit)]
	public struct InputData
	{
		[FieldOffset(0)]
		public int Button;

		[FieldOffset(0)]
		public AxisInfo Axis;

		[FieldOffset(0)]
		public HatInfo Hat;

		[StructLayout(LayoutKind.Sequential)]
		public struct AxisInfo
		{
			public int Axis;

			public int AxisMin;

			public int AxisMax;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct HatInfo
		{
			public int Hat;

			public int HatMask;
		}
	}

	[Union, StructLayout(LayoutKind.Explicit)]
	public struct OutputData
	{
		[FieldOffset(0)]
		public SDL_GamepadButton Button;

		[FieldOffset(0)]
		public AxisInfo Axis;

		[StructLayout(LayoutKind.Sequential)]
		public struct AxisInfo
		{
			public SDL_GamepadAxis Axis;

			public int AxisMin;

			public int AxisMax;
		}
	}
}