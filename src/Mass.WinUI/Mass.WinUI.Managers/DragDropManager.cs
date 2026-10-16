using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Microsoft.UI.Xaml;

namespace Mass.WinUI.Managers;

public static class DragDropManager
{
	[ComImport]
	[Guid("00000122-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface IDropTarget
	{
		[PreserveSig]
		int DragEnter([In][MarshalAs(UnmanagedType.Interface)] IDataObject pDataObj, [In] uint grfKeyState, [In] Point pt, [In][Out] ref uint pdwEffect);

		[PreserveSig]
		int DragOver([In] uint grfKeyState, [In] Point pt, [In][Out] ref uint pdwEffect);

		[PreserveSig]
		int DragLeave();

		[PreserveSig]
		int Drop([In][MarshalAs(UnmanagedType.Interface)] IDataObject pDataObj, [In] uint grfKeyState, [In] Point pt, [In][Out] ref uint pdwEffect);
	}

	private struct Point
	{
		public int x;

		public int y;
	}

	private class NativeDropTarget : IDropTarget
	{
		internal static object ReflectModularCompiler;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe int DragEnter(IDataObject pDataObj, uint grfKeyState, Point pt, ref uint pdwEffect)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772892, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
			return (int)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe int DragOver(uint grfKeyState, Point pt, ref uint pdwEffect)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772893, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			return (int)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe int DragLeave()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772890, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (int)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe int Drop(IDataObject pDataObj, uint grfKeyState, Point pt, ref uint pdwEffect)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772891, new IntPtr(2737336578236L), 15))(null, 0, new IntPtr(0L));
			return (int)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe List<string> ParseDataObject(object dataObject)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772888, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
			return (List<string>)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe NativeDropTarget()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772982, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static bool DetachCreator()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772889, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static NativeDropTarget CheckAccessiblePredicate()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772966, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			return (NativeDropTarget)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe List<string> _FF00_2600(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772967, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
			return (List<string>)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe List<string> _FF00_2700(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772964, new IntPtr(2737336596956L), 15))(null, 0, new IntPtr(0L));
			return (List<string>)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed uint _FF00_2800(object P_0, uint P_1, Point P_2, nint P_3)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772965, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed uint _FF00_2900(object P_0, uint P_1, Point P_2, nint P_3)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772962, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed uint _FF00_2A00(object P_0, uint P_1, Point P_2, nint P_3)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772963, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_2B00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772960, new IntPtr(2737336597996L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00Ⰰ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772961, new IntPtr(2737336584476L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00ⴀ()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772974, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_2E00()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772975, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed uint _FF00_2F00(object P_0, uint P_1, Point P_2, nint P_3)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772972, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed uint _FF00_3000(object P_0, uint P_1, Point P_2, nint P_3)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772973, new IntPtr(2737336587596L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed uint _FF00_3100(uint P_0, Point P_1, nint P_2)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772970, new IntPtr(2737336578236L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed uint _FF00_3200(uint P_0, Point P_1, nint P_2)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772971, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed uint _FF00_3300()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772968, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe sealed uint _FF00㐀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772969, new IntPtr(2737336595916L), 15))(null, 0, new IntPtr(0L));
			return (uint)/*Error near IL_0033: Stack underflow*/;
		}
	}

	[CompilerGenerated]
	private static Action<bool>? m_DragStatusChanged;

	[CompilerGenerated]
	private static Action<string[]>? m_FilesDropped;

	internal static DragDropManager FilterPolicy;

	public unsafe static event Action<bool>? DragStatusChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772867, new IntPtr(2737336602156L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772864, new IntPtr(2737336574076L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	public unsafe static event Action<string[]>? FilesDropped
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772865, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772878, new IntPtr(2737336606316L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern nint GlobalLock(nint hMem);

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GlobalUnlock(nint hMem);

	[DllImport("ole32.dll")]
	private static extern void ReleaseStgMedium(ref STGMEDIUM pmedium);

	[DllImport("ole32.dll")]
	private static extern int RegisterDragDrop(nint hwnd, IDropTarget pDropTarget);

	[DllImport("shell32.dll", CharSet = CharSet.Auto)]
	private static extern uint DragQueryFile(nint hDrop, uint iFile, [Out] StringBuilder lpszFile, uint cch);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static void Register(Window window)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772879, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static bool DecorateCustomModule()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772876, new IntPtr(2737336589676L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/ != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static DragDropManager ReflectAdvancedEvent()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772877, new IntPtr(2737336590716L), 15))(null, 0, new IntPtr(0L));
		return (DragDropManager)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㔀(Action<string[]> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772874, new IntPtr(2737336580316L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㘀(Action<string[]> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772875, new IntPtr(2737336582396L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㜀(Action<string[]> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772872, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00㠀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772873, new IntPtr(2737336575116L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00㤀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772886, new IntPtr(2737336577196L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㨀(Action<string[]> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772887, new IntPtr(2737336581356L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㬀(Action<string[]> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772884, new IntPtr(2737336592796L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㰀(Action<bool> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772885, new IntPtr(2737336585516L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㴀(Action<bool> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772882, new IntPtr(2737336599036L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00㼀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772883, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00䀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772880, new IntPtr(2737336588636L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00䄀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772881, new IntPtr(2737336604236L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00䈀(Action<bool> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772894, new IntPtr(2737336579276L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void _FF00䌀(Action<bool> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790772895, new IntPtr(2737336601116L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}
}
