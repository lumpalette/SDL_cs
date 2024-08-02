namespace SDL3;

/// <summary>
/// The basic state for the system's power supply.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PowerState">documentation</see> for more details.
/// </remarks>
public enum SDL_PowerState
{
	/// <summary>
	/// Error determining power status.
	/// </summary>
	Error = -1,

	/// <summary>
	/// Cannot determine power status.
	/// </summary>
	Unknown,

	/// <summary>
	/// Not plugged in, running on the battery.
	/// </summary>
	OnBattery,

	/// <summary>
	/// Plugged in, no battery available.
	/// </summary>
	NoBattery,

	/// <summary>
	/// Plugged in, charging battery.
	/// </summary>
	Charging,

	/// <summary>
	/// Plugged in, battery charged.
	/// </summary>
	Charged
}