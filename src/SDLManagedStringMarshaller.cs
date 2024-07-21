using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

/// <summary>
/// A marshaller for strings managed by SDL, i.e. strings that the program <b>should not</b> free manually.
/// </summary>
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedOut, typeof(SDLManagedStringMarshaller))]
public static unsafe class SDLManagedStringMarshaller
{
	/// <summary>
	/// Converts an SDL-managed string into a managed C# <see cref="string"/>.
	/// </summary>
	/// <param name="unmanaged">A pointer to the SDL string.</param>
	/// <returns>A managed <see cref="string"/>.</returns>
	public static string? ConvertToManaged(byte* unmanaged)
	{
		return Utf8StringMarshaller.ConvertToManaged(unmanaged);
	}
}