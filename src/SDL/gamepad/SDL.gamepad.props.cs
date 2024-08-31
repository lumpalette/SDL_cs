namespace SDL3;

unsafe partial class SDL
{
	partial class Prop
	{
		/// <summary>
		/// Properties used in <see cref="SDL.GetGamepadProperties(SDL_Gamepad*)"/>.
		/// </summary>
		public static class Gamepad
		{
			/// <summary>
			/// True if this gamepad has an LED that has adjustable brightness.
			/// </summary>
			public const string CapMonoLEDBoolean = Joystick.CapMonoLEDBoolean;

			/// <summary>
			/// True if this gamepad has an LED that has adjustable color.
			/// </summary>
			public const string CapRGBLEDBoolean = Joystick.CapRGBLEDBoolean;

			/// <summary>
			/// True if this gamepad has a player LED.
			/// </summary>
			public const string CapPlayerLEDBoolean = Joystick.CapPlayerLEDBoolean;

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