using System.Runtime.InteropServices;

namespace SDL_cs
{
	/// <summary>
	/// Keyboard device event structure (<see cref="SDL_Event.KeyboardDevice"/>).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_KeyboardDeviceEvent">documentation</see> for more details.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_KeyboardDeviceEvent
	{
		/// <summary>
		/// Either <see cref="SDL_EventType.KeyboardAdded"/> or <see cref="SDL_EventType.KeyboardRemoved"/>.
		/// </summary>
		public SDL_EventType Type;

		private readonly uint _reserved;

		/// <summary>
		/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
		/// </summary>
		public ulong Timestamp;

		/// <summary>
		/// The keyboard instance ID.
		/// </summary>
		public SDL_KeyboardId Which;
	}
}