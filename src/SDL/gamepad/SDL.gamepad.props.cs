namespace SDL3;

public static unsafe partial class SDL
{
	public static partial class Prop
	{
		/// <summary>
		/// Properties used in <see cref="SDL.GetGamepadProperties(SDL_Gamepad*)"/>.
		/// </summary>
		public static class Gamepad
		{
			/// <summary>
			/// True if this gamepad has an LED that has adjustable brightness.
			/// </summary>
			public const string CapMonoLedBoolean = Joystick.CapMonoLedBoolean;

			/// <summary>
			/// True if this gamepad has an LED that has adjustable color.
			/// </summary>
			public const string CapRGBLedBoolean = Joystick.CapRGBLedBoolean;

			/// <summary>
			/// True if this gamepad has a player LED.
			/// </summary>
			public const string CapPlayerLedBoolean = Joystick.CapPlayerLedBoolean;

			/// <summary>
			/// True if this gamepad has left/right rumble.
			/// </summary>
			public const string CapRumbleBoolean = Joystick.CapRumbleBoolean;

			/// <summary>
			/// True if this gamepad has simple trigger rumble.
			/// </summary>
			public const string CapTriggerRumbleBoolean = Joystick.CapTriggerRumbleBoolean;
		}
	}
}