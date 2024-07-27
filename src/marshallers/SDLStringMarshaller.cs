using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

/// <summary>
/// A marshaller for UTF-8 strings that are managed by SDL, i.e. strings that the program <b>should not</b> free manually.
/// </summary>
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedOut, typeof(SDLStringMarshaller))]
public static unsafe class SDLStringMarshaller
{
	/// <summary>
	/// Converts an SDL string into a managed C# <see cref="string"/>.
	/// </summary>
	/// <param name="unmanaged">A pointer to the SDL string.</param>
	/// <returns>A managed <see cref="string"/>.</returns>
	public static string? ConvertToManaged(byte* unmanaged)
	{
		return Utf8StringMarshaller.ConvertToManaged(unmanaged);
	}
}