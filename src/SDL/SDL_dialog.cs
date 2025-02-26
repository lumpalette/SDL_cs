// SDL_dialog.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_dialog.h.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// An entry for filters for file dialogs.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DialogFileFilter">documentation</see> for more details.
/// </remarks>
public unsafe struct SDL_DialogFileFilter
{
	public byte* Name;

	public byte* Pattern;
}

/// <summary>
/// Various types of file dialogs.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FileDialogType">documentation</see> for more details.
/// </remarks>
public enum SDL_FileDialogType
{
	OpenFile,
	SaveFile,
	OpenFolder
}

unsafe partial class SDL
{
	partial class Prop
	{
		/// <summary>
		/// Properties used for <see cref="ShowFileDialogWithProperties"/>.
		/// </summary>
		public static class FileDialog
		{
			/// <summary>
			/// A pointer to a list of <see cref="SDL_DialogFileFilter"/> structs, which will be used as filters for file-based selections.
			/// Ignored if the dialog is an "Open Folder" dialog. If non-null, the array of filters must remain valid at least until the
			/// callback is invoked.
			/// </summary>
			public const string FiltersPointer = "SDL.filedialog.filters";

			/// <summary>
			/// The number of filters in the array of filters, if it exists.
			/// </summary>
			public const string NumFiltersNumber = "SDL.filedialog.nfilters";

			/// <summary>
			/// The window that the dialog should be modal for.
			/// </summary>
			public const string WindowPointer = "SDL.filedialog.window";

			/// <summary>
			/// The default folder or file to start the dialog at.
			/// </summary>
			public const string LocationString = "SDL.filedialog.location";

			/// <summary>
			/// True to allow the user to select more than one entry.
			/// </summary>
			public const string ManyBoolean = "SDL.filedialog.many";

			/// <summary>
			/// The title for the dialog.
			/// </summary>
			public const string TitleString = "SDL.filedialog.title";

			/// <summary>
			/// The label that the accept button should have.
			/// </summary>
			public const string AcceptString = "SDL.filedialog.accept";

			/// <summary>
			/// The label that the cancel button should have.
			/// </summary>
			public const string CancelString = "SDL.filedialog.cancel";
		}
	}

	/// <summary>
	/// Displays a dialog that lets the user select a file on their filesystem.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowOpenFileDialog">documentation</see> for more details.
	/// </remarks>
	/// <param name="callback">A function pointer to be invoked when the user selects a file and accepts, or cancels the dialog, or an error occurs.</param>
	/// <param name="userData">An optional pointer to pass extra data to the callback when it will be invoked.</param>
	/// <param name="window">The window that the dialog should be modal for, may be <see langword="null"/>. Not all platforms support this option.</param>
	/// <param name="filters">A list of filters, may be <see langword="null"/>. Not all platforms support this option, and platforms that do support it may allow the user to ignore the filters. If non-null, it must remain valid at least until the callback is invoked.</param>
	/// <param name="numFilters">The number of filters. Ignored if filters is <see langword="null"/>.</param>
	/// <param name="defaultLocation">The default folder or file to start the dialog at, may be <see langword="null"/>. Not all platforms support this option.</param>
	/// <param name="allowMany">If true, the user will be allowed to select multiple entries. Not all platforms support this option.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowOpenFileDialog", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void ShowOpenFileDialog(delegate* unmanaged[Cdecl]<nint, byte*, int, void> callback, nint userData, SDL_Window* window, [Const] SDL_DialogFileFilter* filters, int numFilters, string defaultLocation, [MarshalAs(BoolSize)] bool allowMany);

	/// <summary>
	/// Displays a dialog that lets the user choose a new or existing file on their filesystem.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowSaveFileDialog">documentation</see> for more details.
	/// </remarks>
	/// <param name="callback">A function pointer to be invoked when the user selects a file and accepts, or cancels the dialog, or an error occurs.</param>
	/// <param name="userData">An optional pointer to pass extra data to the callback when it will be invoked.</param>
	/// <param name="window">The window that the dialog should be modal for, may be <see langword="null"/>. Not all platforms support this option.</param>
	/// <param name="filters">A list of filters, may be <see langword="null"/>. Not all platforms support this option, and platforms that do support it may allow the user to ignore the filters. If non-null, it must remain valid at least until the callback is invoked.</param>
	/// <param name="numFilters">The number of filters. Ignored if filters is <see langword="null"/>.</param>
	/// <param name="defaultLocation">The default folder or file to start the dialog at, may be <see langword="null"/>. Not all platforms support this option.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowSaveFileDialog", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void ShowSaveFileDialog(delegate* unmanaged[Cdecl]<nint, byte*, int, void> callback, nint userData, SDL_Window* window, [Const] SDL_DialogFileFilter* filters, int numFilters, string defaultLocation);

	/// <summary>
	/// Displays a dialog that lets the user select a folder on their filesystem.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowOpenFolderDialog">documentation</see> for more details.
	/// </remarks>
	/// <param name="callback">A function pointer to be invoked when the user selects a file and accepts, or cancels the dialog, or an error occurs.</param>
	/// <param name="userData">An optional pointer to pass extra data to the callback when it will be invoked.</param>
	/// <param name="window">The window that the dialog should be modal for, may be <see langword="null"/>. Not all platforms support this option.</param>
	/// <param name="defaultLocation">The default folder or file to start the dialog at, may be <see langword="null"/>. Not all platforms support this option.</param>
	/// <param name="allowMany">If true, the user will be allowed to select multiple entries. Not all platforms support this option.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowOpenFolderDialog", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void ShowOpenFolderDialog(delegate* unmanaged[Cdecl]<nint, byte*, int, void> callback, nint userData, SDL_Window* window, string defaultLocation, [MarshalAs(BoolSize)] bool allowMany);

	/// <summary>
	/// Create and launch a file dialog with the specified properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowFileDialogWithProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="type">The type of file dialog.</param>
	/// <param name="callback">A function pointer to be invoked when the user selects a file and accepts, or cancels the dialog, or an error occurs.</param>
	/// <param name="userData">An optional pointer to pass extra data to the callback when it will be invoked.</param>
	/// <param name="props">The properties to use.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowFileDialogWithProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void ShowFileDialogWithProperties(SDL_FileDialogType type, delegate* unmanaged[Cdecl]<nint, byte*, int, void> callback, nint userData, SDL_PropertiesId props);
}