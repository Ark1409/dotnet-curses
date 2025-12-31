using System;
using System.Runtime.InteropServices;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

// startup/shutdown, trace (debugging), termcaps (terminal metadata), etc.

namespace Mindmagma.Curses.Interop
{
    internal static partial class Native
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool dt_can_change_color();
        private static dt_can_change_color call_can_change_color = NativeToDelegate<dt_can_change_color>("can_change_color");
        internal static bool can_change_color() => call_can_change_color();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_cbreak();
        private static dt_cbreak call_cbreak = NativeToDelegate<dt_cbreak>("cbreak");
        internal static int cbreak() => call_cbreak();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_endwin();
        private static dt_endwin call_endwin = NativeToDelegate<dt_endwin>("endwin");
        internal static int endwin() => call_endwin();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool dt_has_colors();
        private static dt_has_colors call_has_colors = NativeToDelegate<dt_has_colors>("has_colors");
        internal static bool has_colors() => call_has_colors();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_initscr();
        private static dt_initscr call_initscr = NativeToDelegate<dt_initscr>("initscr");
        internal static IntPtr initscr() => call_initscr();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool dt_isendwin();
        private static dt_isendwin call_isendwin = NativeToDelegate<dt_isendwin>("isendwin");
        internal static bool isendwin() => call_isendwin();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_napms(int milliseconds);
        private static dt_napms call_napms = NativeToDelegate<dt_napms>("napms");
        internal static int napms(int milliseconds) => call_napms(milliseconds);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_nocbreak();
        private static dt_nocbreak call_nocbreak = NativeToDelegate<dt_nocbreak>("nocbreak");
        internal static int nocbreak() => call_nocbreak();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_noecho();
        private static dt_noecho call_noecho = NativeToDelegate<dt_noecho>("noecho");
        internal static int noecho() => call_noecho();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_noraw();
        private static dt_noraw call_noraw = NativeToDelegate<dt_noraw>("noraw");
        internal static int noraw() => call_noraw();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_raw();
        private static dt_raw call_raw = NativeToDelegate<dt_raw>("raw");
        internal static int raw() => call_raw();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_halfdelay(int tenths);
        private static dt_halfdelay call_halfdelay = NativeToDelegate<dt_halfdelay>("halfdelay");
        internal static int halfdelay(int tenths) => call_halfdelay(tenths);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_timeout(int delay);
        private static dt_timeout call_timeout = NativeToDelegate<dt_timeout>("timeout");
        internal static int timeout(int delay) => call_timeout(delay);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate IntPtr dt_tigetstr(string cap);
        private static dt_tigetstr call_tigetstr = NativeToDelegate<dt_tigetstr>("tigetstr");
        internal static IntPtr tigetstr(string cap) => call_tigetstr(cap);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_tigetflag(string cap);
        private static dt_tigetflag call_tigetflag = NativeToDelegate<dt_tigetflag>("tigetflag");
        internal static int tigetflag(string cap) => call_tigetflag(cap);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_tigetnum(string cap);
        private static dt_tigetnum call_tigetnum = NativeToDelegate<dt_tigetnum>("tigetnum");
        internal static int tigetnum(string cap) => call_tigetnum(cap);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate IntPtr dt_tiparmi1(string str, int i0);
        private static dt_tiparmi1 call_tiparmi1 = NativeToDelegate<dt_tiparmi1>("tiparm");
        internal static IntPtr tiparm(string str, int i0) => call_tiparmi1(str, i0);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate IntPtr dt_tiparmi2(string str, int i0, int i1);
        private static dt_tiparmi2 call_tiparmi2 = NativeToDelegate<dt_tiparmi2>("tiparm");
        internal static IntPtr tiparm(string str, int i0, int i1) => call_tiparmi2(str, i0, i1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate IntPtr dt_tiparmi3(string str, int i0, int i1, int i2);
        private static dt_tiparmi3 call_tiparmi3 = NativeToDelegate<dt_tiparmi3>("tiparm");
        internal static IntPtr tiparm(string str, int i0, int i1, int i2) => call_tiparmi3(str, i0, i1, i2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate IntPtr dt_tiparmi4(string str, int i0, int i1, int i2, int i3);
        private static dt_tiparmi4 call_tiparmi4 = NativeToDelegate<dt_tiparmi4>("tiparm");
        internal static IntPtr tiparm(string str, int i0, int i1, int i2, int i3) => call_tiparmi4(str, i0, i1, i2, i3);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate IntPtr dt_tiparms1(string str, string s1);
        private static dt_tiparms1 call_tiparms1 = NativeToDelegate<dt_tiparms1>("tiparm");
        internal static IntPtr tiparm(string str, string s1) => call_tiparms1(str, s1);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate IntPtr dt_tiparms2(string str, string s1, string s2);
        private static dt_tiparms2 call_tiparms2 = NativeToDelegate<dt_tiparms2>("tiparm");
        internal static IntPtr tiparm(string str, string s1, string s2) => call_tiparms2(str, s1, s2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_tputs(string str, int affcnt, IntPtr /* int (*putc)(int) */ putc);
        private static dt_tputs call_tputs = NativeToDelegate<dt_tputs>("tputs");
        internal static int tputs(string str, int affcnt, IntPtr /* int (*putc)(int) */ putc) => call_tputs(str, affcnt, putc);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_putp(string str);
        private static dt_putp call_putp = NativeToDelegate<dt_putp>("putp");
        internal static int putp(string str) => call_putp(str);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_setupterm(string str, int fildes, IntPtr /* int* */ errret);
        private static dt_setupterm call_setupterm = NativeToDelegate<dt_setupterm>("setupterm");
        internal static int setupterm(string str, int filedes, IntPtr /* int* */ errret) => call_setupterm(str, filedes, errret);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_vidputs(uint attrs, IntPtr /* int (*putc)(int) */ putc);
        private static dt_vidputs call_vidputs = NativeToDelegate<dt_vidputs>("vidputs");
        internal static int vidputs(uint attrs, IntPtr /* int (*putc)(int) */ putc) => call_vidputs(attrs, putc);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_vidattr(uint attrs);
        private static dt_vidattr call_vidattr = NativeToDelegate<dt_vidattr>("vidattr");
        internal static int vidattr(uint attrs) => call_vidattr(attrs);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_vid_puts(int attrs, int pair, IntPtr /* void* = NULL */ opts,  IntPtr /* int (*putc)(int) */ putc);
        private static dt_vid_puts call_vid_puts = NativeToDelegate<dt_vid_puts>("vid_puts");
        internal static int vid_puts(uint attrs, int pair, IntPtr /* void* = NULL */ opts,  IntPtr /* int (*putc)(int) */ putc) => call_vid_puts(attrs, pair, opts, putc);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_vid_attr(uint attrs, int pair, IntPtr /* void* = NULL */ opts);
        private static dt_vid_attr call_vid_attr = NativeToDelegate<dt_vid_attr>("vid_attr");
        internal static int vid_attr(uint attrs, int pair, IntPtr /* void* = NULL */ opts) => call_vid_attr(attrs, pair, opts);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_mvcur(int oldrow, int oldcol, int newrow, int newcol);
        private static dt_mvcur call_mvcur = NativeToDelegate<dt_mvcur>("mvcur");
        internal static int mvcur(int oldrow, int oldcol, int newrow, int newcol) => call_mvcur(oldrow, oldcol, newrow, newcol);
    }
}
