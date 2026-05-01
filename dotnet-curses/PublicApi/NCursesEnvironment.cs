using System;
using System.Runtime.InteropServices;
using Mindmagma.Curses.Interop;

// startup/shutdown, trace (debugging), termcaps (terminal metadata), etc.

namespace Mindmagma.Curses
{
    public static partial class NCurses
    {

        public static bool CanChangeColor()
        {
            return Native.can_change_color();
        }

        /// <summary>
        /// Individual characters will be returned (rather than "cooked" line-input mode), but some control characters (such as CTRL+C) may still be processed internally.
        /// </summary>
        public static void CBreak()
        {
            int result = Native.cbreak();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(CBreak));
        }

        public static void EndWin()
        {
            int result = Native.endwin();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(EndWin));
        }

        public static bool HasColors()
        {
            return Native.has_colors();
        }

        /// <summary>
        /// Retrieves a pointer to <c>stdscr</c>, the default <c>WINDOW</c> representing the entire terminal screen.
        /// Will be <see cref="IntPtr.Zero">NULL</see> if the library has not been initialized with <see cref="InitScreen"/>
        /// </summary>
        public static IntPtr StdScr { get; private set; } = IntPtr.Zero;

        public static IntPtr InitScreen()
        {
            IntPtr result = Native.initscr();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(InitScreen));
            return StdScr = result;
        }

        public static bool IsEndWin()
        {
            return Native.isendwin();
        }

        public static int Nap(int milliseconds)
        {
            int result = Native.napms(milliseconds);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Nap));
            return result;
        }

        /// <summary>
        /// Returns the terminal to "cooked" line-input mode.
        /// </summary>
        public static void NoCBreak()
        {
            int result = Native.nocbreak();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NoCBreak));
        }

        public static void NoEcho()
        {
            int result = Native.noecho();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NoEcho));
        }

        /// <summary>
        /// Returns the terminal to "cooked" line-input mode.
        /// </summary>
        public static void NoRaw()
        {
            int result = Native.noraw();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NoRaw));
        }

        /// <summary>
        /// Individual characters will be returned (rather than "cooked" line-input mode) with no internal processing of control characters.
        /// </summary>
        public static void Raw()
        {
            int result = Native.raw();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Raw));
        }

        /// <summary>
        /// Sets input to half-delay mode where characters are immediately available for input but blocking for tenths of a second with no input ERR is returned.
        /// </summary>
        public static void HalfDelay(int tenths)
        {
            int result = Native.halfdelay(tenths);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(HalfDelay));
        }

        /// <summary>
        /// Sets blocking or non-blocking mode.
        /// If delay is negative, blocking read is used.
        /// If delay is zero, non-blocking read is used and no input waiting returns ERR.
        /// If delay is positive, read blocks for delay milliseconds and then returns ERR if there is still no input.
        /// </summary>
        public static void TimeOut(int delay)
        {
            int result = Native.timeout(delay);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(TimeOut));
        }

        public static bool Tigetflag(string s)
        {
            int result = Native.tigetflag(s);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetflag));
            return result != 0;
        }
        public static bool Tigetuserflag(string s)
        {
            int result = Native.tigetflag(s);
            if (result <= -1) result = 0;
            return result != 0;
        }

        public static int Tigetnum(string s)
        {
            int result = Native.tigetnum(s);
            NativeExceptionHelper.ThrowOnFailure(result + 1, nameof(Tigetflag));
            return result;
        }

        public static int Tigetusernum(string s)
        {
            int result = Native.tigetnum(s);
            if (result <= -2) result = -1;
            return result;
        }

#nullable enable
        public static string? Tigetstr(string s)
        {
            IntPtr result = Native.tigetstr(s);
            if (result == IntPtr.Zero) return null;
            if (result == -1)
            {
                result = IntPtr.Zero;
                NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            }

            return Marshal.PtrToStringUTF8(result);
        }

        public static string? Tigetuserstr(string s)
        {
            IntPtr result = Native.tigetstr(s);
            if (result == IntPtr.Zero || result <= -1) return null;

            return Marshal.PtrToStringUTF8(result);
        }
#nullable disable

        public static string Tiparm(string s, int i0)
        {
            IntPtr result = Native.tiparm(s, i0);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public static string Tiparm(string s, int i0, int i1)
        {
            IntPtr result = Native.tiparm(s, i0, i1);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public static string Tiparm(string s, int i0, int i1, int i2)
        {
            IntPtr result = Native.tiparm(s, i0, i1, i2);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public static string Tiparm(string s, int i0, int i1, int i2, int i3)
        {
            IntPtr result = Native.tiparm(s, i0, i1, i2, i3);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public static string Tiparm(string s, int i0, int i1, int i2, int i3, int i4)
        {
            IntPtr result = Native.tiparm(s, i0, i1, i2, i3, i4);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public static string Tiparm(string s, int i0, int i1, int i2, int i3, int i4, int i5)
        {
            IntPtr result = Native.tiparm(s, i0, i1, i2, i3, i4, i5);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public static string Tiparm(string s, int i0, int i1, int i2, int i3, int i4, int i5, int i6)
        {
            IntPtr result = Native.tiparm(s, i0, i1, i2, i3, i4, i5, i6);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public static string Tiparm(string s, int i0, int i1, int i2, int i3, int i4, int i5, int i6, int i7)
        {
            IntPtr result = Native.tiparm(s, i0, i1, i2, i3, i4, i5, i6, i7);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public static string Tiparm(string s, int i0, int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8)
        {
            IntPtr result = Native.tiparm(s, i0, i1, i2, i3, i4, i5, i6, i7, i8);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public static string Tiparm(string s, string s1)
        {
            IntPtr result = Native.tiparm(s, s1);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public static string Tiparm(string s, string s1, string s2)
        {
            IntPtr result = Native.tiparm(s, s1, s2);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tigetstr));
            return Marshal.PtrToStringUTF8(result);
        }

        public delegate int PutcFunc2(char c);
        public delegate void PutcFunc3(char c);

        public delegate void PutcFunc4(int c);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int PutcFunc(int c);

        public static void Tputs(string s, int affcnt, PutcFunc func)
        {
            var funcPointer = Marshal.GetFunctionPointerForDelegate(func);
            int result = Native.tputs(s, affcnt, funcPointer);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Tputs));
        }

        public static void Tputs(string s, int affcnt, PutcFunc2 func)
        {
            PutcFunc internalFunc = c => func((char)c);
            Tputs(s, affcnt, internalFunc);
        }

        public static void Tputs(string s, int affcnt, PutcFunc3 func)
        {
            PutcFunc internalFunc = c => { func((char)c); return c; };
            Tputs(s, affcnt, internalFunc);
        }

        public static void Tputs(string s, int affcnt, PutcFunc4 func)
        {
            PutcFunc internalFunc = c => { func(c); return c; };
            Tputs(s, affcnt, internalFunc);
        }

        public static void Setupterm(string s, int fileno)
        {
            var ptr = IntPtr.Zero;
            try
            {
                ptr = Marshal.AllocHGlobal(Marshal.SizeOf<int>());
                Marshal.WriteInt32(ptr, 0);
                int result = Native.setupterm(s, fileno, ptr);
                NativeExceptionHelper.ThrowOnFailure(result, nameof(Setupterm));
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        public static void Vidputs(uint attrs, PutcFunc putc)
        {
            var funcPointer = Marshal.GetFunctionPointerForDelegate(putc);
            int result = Native.vidputs(attrs, funcPointer);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Vidputs));
        }

        public static void Vidputs(uint attrs, PutcFunc2 putc)
        {
            PutcFunc internalFunc = c => putc((char)c);
            Vidputs(attrs, internalFunc);
        }

        public static void Vidputs(uint attrs, PutcFunc3 putc)
        {
            PutcFunc internalFunc = c => { putc((char)c); return c; };
            Vidputs(attrs, internalFunc);
        }

        public static void Vidputs(uint attrs, PutcFunc4 putc)
        {
            PutcFunc internalFunc = c => { putc(c); return c; };
            Vidputs(attrs, internalFunc);
        }

        public static void Vidattr(uint attrs)
        {
            int result = Native.vidattr(attrs);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Vidattr));
        }

        public static void VidPuts(uint attrs, int pair, PutcFunc putc)
        {
            var funcPointer = Marshal.GetFunctionPointerForDelegate(putc);
            int result = Native.vid_puts(attrs, pair, IntPtr.Zero, funcPointer);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(VidPuts));
        }

        public static void VidPuts(uint attrs, int pair, PutcFunc2 putc)
        {
            PutcFunc internalFunc = c => putc((char)c);
            VidPuts(attrs, pair, internalFunc);
        }

        public static void VidPuts(uint attrs, int pair, PutcFunc3 putc)
        {
            PutcFunc internalFunc = c => { putc((char)c); return c; };
            VidPuts(attrs, pair, internalFunc);
        }

        public static void VidPuts(uint attrs, int pair, PutcFunc4 putc)
        {
            PutcFunc internalFunc = c => { putc(c); return c; };
            VidPuts(attrs, pair, internalFunc);
        }

        public static void VidAttr(uint attrs, int pair)
        {
            int result = Native.vid_attr(attrs, pair, IntPtr.Zero);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(VidAttr));
        }

        public static void Mvcur(int oldrow, int oldcol, int newrow, int newcol)
        {
            int result = Native.mvcur(oldrow, oldcol, newrow, newcol);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Mvcur));
        }

        public static nint Newterm(string name)
        {
            // Rely on https://github.com/mirror/ncurses/blob/87c2c84cbd2332d6d94b12a1dcaf12ad1a51a938/ncurses/base/lib_newterm.c#L181-L182
            nint result = Native.newterm(name, nint.Zero, nint.Zero);
            if (result == nint.Zero || result == -1)
            {
                NativeExceptionHelper.ThrowOnFailure(nint.Zero, nameof(Newterm));
            }
            return result;
        }

        public static nint Setterm(nint newscr)
        {
            nint result = Native.set_term(newscr);
            if (result == nint.Zero)
            {
                NativeExceptionHelper.ThrowOnFailure(nint.Zero, nameof(Setterm));
            }
            return result;
        }

        public static void Delscreen(nint newscr)
        {
            Native.delscreen(newscr);
        }

        public static void DefProgMode()
        {
            var result = Native.def_prog_mode();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DefProgMode));
        }

        public static void DefShellMode()
        {
            var result = Native.def_shell_mode();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DefShellMode));
        }

        public static void ResetProgMode()
        {
            var result = Native.reset_prog_mode();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ResetProgMode));
        }

        public static void ResetShellMode()
        {
            var result = Native.reset_shell_mode();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ResetShellMode));
        }

        public static void Savetty()
        {
            var result = Native.savetty();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Savetty));
        }

        public static void Resetty()
        {
            var result = Native.resetty();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Resetty));
        }

        public static void DefProgMode(nint screen)
        {
            var result = Native.def_prog_mode_sp(screen);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DefProgMode));
        }

        public static void DefShellMode(nint screen)
        {
            var result = Native.def_shell_mode_sp(screen);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DefShellMode));
        }

        public static void ResetProgMode(nint screen)
        {
            var result = Native.reset_prog_mode_sp(screen);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ResetProgMode));
        }

        public static void ResetShellMode(nint screen)
        {
            var result = Native.reset_shell_mode_sp(screen);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ResetShellMode));
        }

        public static void Savetty(nint screen)
        {
            var result = Native.savetty_sp(screen);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Savetty));
        }

        public static void Resetty(nint screen)
        {
            var result = Native.resetty_sp(screen);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Resetty));
        }

        /// <summary>
        /// Controls whether the calling application is able to use user-defined or nonstandard names which may be
        /// compiled into the terminfo description, i.e., via the terminfo or termcap interfaces. Normally these names
        /// are available for use, since the essential decision is made by using the -x option of tic to compile
        /// extended terminal definitions. However you can disable this feature to ensure compatibility with other
        /// implementations of curses. </summary>
        /// <param name="enable">Wheter to enable or disable use of extended (user-defined) names. Defaults to
        /// <c>true</c></param>
        /// <returns>The old value of the flag.</returns>
        public static bool UseExtendedNames(bool enable = true)
        {
            var result = Native.use_extended_names(enable);
            return result != 0;
        }
    }
}
