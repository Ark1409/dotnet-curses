using System;
using System.Runtime.InteropServices;

// internal support, curses functions are referenced in the other partial classes

// ncurses export list
// http://invisible-island.net/ncurses/man/ncurses.3x.html#h3-Routine-Name-Index

// depends upon a modified version of this project until .NET adds this capability
// https://github.com/mellinoe/nativelibraryloader
// https://github.com/dotnet/corefx/issues/17135

namespace Mindmagma.Curses.Interop
{
    internal static partial class Native
    {
        private static D NativeToDelegate<D>(string exportedFunctionName)
        {
            return NCursesLibraryHandle.lib.LoadFunction<D>(exportedFunctionName);
        }

        private static int MarshalInt(string exportedSymbolName)
        {
            IntPtr address = NCursesLibraryHandle.lib.LoadFunction(exportedSymbolName);
            return (int)Marshal.PtrToStructure(address, typeof(int));
        }

        private static T MarshalStruct<T>(string exportedSymbolName) where T : unmanaged
        {
            IntPtr address = NCursesLibraryHandle.lib.LoadFunction(exportedSymbolName);
            return (T)Marshal.PtrToStructure(address, typeof(T));
        }

        private static nint MarshalNint(string exportedSymbolName)
        {
            return NCursesLibraryHandle.lib.LoadFunction(exportedSymbolName);
        }
    }
}
