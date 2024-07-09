namespace SDL_cs;

partial class SDL_Prop
{
	/// <summary>
	/// Properties used in <see cref="SDL.GetJoystickProperties(SDL_Joystick*)"/>.
	/// </summary>
	public static class Joystick
	{
		/// <summary>
		/// True if this joystick has an LED that has adjustable 
		/// </summary>
		public const string CapMonoLedBoolean = "SDL.joystick.cap.mono_led";

		/// <summary>
		/// True if this joystick has an LED that has adjustable color.
		/// </summary>
		public const string CapRGBLedBoolean = "SDL.joystick.cap.rgb_led";

		/// <summary>
		/// True if this joystick has a player LED.
		/// </summary>
		public const string CapPlayerLedBoolean = "SDL.joystick.cap.player_led";

		/// <summary>
		/// True if this joystick has left/right rumble.
		/// </summary>
		public const string CapRumbleBoolean = "SDL.joystick.cap.rumble";

		/// <summary>
		/// True if this joystick has simple trigger rumble.
		/// </summary>
		public const string CapTriggerRumbleBoolean = "SDL.joystick.cap.trigger_rumble";
	}
}