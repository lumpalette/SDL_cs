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
	[Union]
	[StructLayout(LayoutKind.Explicit)]
	public struct InputUnion
	{
		[StructLayout(LayoutKind.Sequential)]
		public struct AxisStruct
		{
			public SDL_GamepadAxis Axis;

			public int AxisMin;

			public int AxisMax;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct HatStruct
		{
			public int Hat;

			public int HatMask;
		}

		[FieldOffset(0)]
		public SDL_GamepadButton Button;

		[FieldOffset(0)]
		public AxisStruct Axis;

		[FieldOffset(0)]
		public HatStruct Hat;
	}

	[Union]
	[StructLayout(LayoutKind.Explicit)]
	public struct OutputUnion
	{
		[StructLayout(LayoutKind.Sequential)]
		public struct AxisStruct
		{
			public SDL_GamepadAxis Axis;

			public int AxisMin;

			public int AxisMax;
		}

		[FieldOffset(0)]
		public SDL_GamepadButton Button;

		[FieldOffset(0)]
		public AxisStruct Axis;
	}

	public SDL_GamepadBindingType Type;

	public InputUnion Input;

	public OutputUnion Output;
}