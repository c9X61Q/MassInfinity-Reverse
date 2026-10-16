using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mass.WinUI.Models;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(Mass_WinUI_ViewModels_ChatViewModelWinRTTypeDetails))]
public class InstanceViewModel : ObservableObject
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COperation_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GameInstanceModel instance;

		private TaskAwaiter _003C_003Eu__1;

		internal static object DecorateExtendedDic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CheckVisibleObject()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CheckCentralDecorator()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00帀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778130, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00开()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0032: Expected I4, but got Obj
			//IL_0219: Expected Obj, but got Ref
			//IL_0165: Expected Obj, but got Ref
			//IL_009b: Expected Obj, but got Ref
			//IL_0139: Expected Obj, but got I4
			//IL_00e5: Expected Obj, but got I4
			//IL_0225->IL0019: Incompatible stack heights: 0 vs 1
			//IL_0208->IL0019: Incompatible stack heights: 3 vs 1
			//IL_0215->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0230->IL0019: Incompatible stack types: I4 vs Obj
			//IL_017c->IL005b: Incompatible stack heights: 1 vs 0
			//IL_0057->IL005b: Incompatible stack heights: 1 vs 0
			//IL_00a5->IL005b: Incompatible stack heights: 1 vs 0
			//IL_0146->IL005b: Incompatible stack heights: 2 vs 0
			//IL_0134->IL005b: Incompatible stack heights: 2 vs 0
			//IL_011c->IL005b: Incompatible stack heights: 2 vs 0
			//IL_00f2->IL005b: Incompatible stack heights: 2 vs 0
			//IL_0161->IL005b: Incompatible stack heights: 4 vs 0
			//IL_00c1->IL005b: Incompatible stack heights: 2 vs 0
			//IL_0151->IL005b: Incompatible stack heights: 2 vs 0
			//IL_0127->IL005b: Incompatible stack heights: 2 vs 0
			//IL_00fd->IL005b: Incompatible stack heights: 2 vs 0
			//IL_00e0->IL005b: Incompatible stack heights: 1 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					return;
				default:
					if (obj != null)
					{
						if (1 == 0)
						{
							_ = 1;
						}
						goto IL_005b;
					}
					goto IL_0161;
				case 2:
					goto IL_01fa;
				case 4:
					_ = 3;
					break;
				case 1:
					{
						obj = (object)Unsafe.AsPointer(ref this);
						if (0 == 0)
						{
							obj2 = 0;
						}
						break;
					}
					IL_0161:
					obj = (object)Unsafe.AsPointer(ref this);
					if (3 == 0)
					{
						_ = 9;
					}
					goto IL_005b;
					IL_01fa:
					_ = -2;
					_ = 4;
					break;
					IL_005b:
					while (true)
					{
						switch ((int)/*Error near IL_0090: Stack underflow*/)
						{
						case 10:
							return;
						case 1:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 3;
							continue;
						case 9:
							_ = 2;
							continue;
						case 3:
							if (&obj != null)
							{
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto case 6;
						case 6:
							obj = 0;
							if (5 == 0)
							{
								_ = 5;
							}
							continue;
						case 5:
							if (false)
							{
								_ = 8;
							}
							continue;
						default:
							_ = ref obj;
							_ = 11;
							continue;
						case 2:
							obj = -1;
							if (4 == 0)
							{
								_ = 4;
							}
							continue;
						case 8:
							_ = ref obj;
							_ = 10;
							continue;
						case 7:
							break;
						case 11:
							goto IL_01fa;
						}
						break;
					}
					goto IL_0161;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00怀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778131, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00愀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00戀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00挀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778128, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00搀(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0046->IL0019: Incompatible stack heights: 2 vs 1
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			while (true)
			{
				switch ((int)obj)
				{
				default:
					return;
				case 1:
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00攀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778129, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private List<GameInstanceModel> _allInstances;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<GameInstanceModel>? operationCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<GameInstanceModel>? closeInstanceCommand;

	internal static InstanceViewModel ReflectActiveCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int SelectedCategoryIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (int)_FF00_FF00_2800();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_1B00((uint)value);
		}
	}

	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public ObservableCollection<GameInstanceModel> Instances
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_2F00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00_FF00_2A00(value);
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IAsyncRelayCommand<GameInstanceModel> OperationCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_3100();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IRelayCommand<GameInstanceModel> CloseInstanceCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_FF00_2200();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InstanceViewModel()
	{
		//IL_0046: Expected I4, but got Obj
		//IL_0030->IL0039: Incompatible stack types: I4 vs Obj
		//IL_0065->IL0039: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		InstanceViewModel instanceViewModel = this;
		if (1 == 0)
		{
			instanceViewModel = (InstanceViewModel)1;
		}
		while (true)
		{
			switch ((int)instanceViewModel)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				instanceViewModel = this;
				if (false)
				{
					instanceViewModel = (InstanceViewModel)0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RefreshCollection()
	{
		_FF00_FF00_2100();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyFilter()
	{
		_FF00_FF00_2400();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COperation_003Ed__11))]
	[RelayCommand]
	public Task Operation(GameInstanceModel instance)
	{
		return (Task)_FF00_FF00_2E00(instance);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	public void CloseInstance(GameInstanceModel instance)
	{
		_FF00_FF00_2B00(instance);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnSelectedCategoryIndexChanged(uint value)
	{
		_FF00_FF00Ḁ(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ControlCache()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static InstanceViewModel CalcUser()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ᨀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778115, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_1B00(uint P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_004b: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_005d->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00ab->IL0087: Incompatible stack heights: 1 vs 0
		//IL_0050->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0077->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b9->IL0015: Incompatible stack heights: 1 vs 0
		//IL_00a1->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					obj = 2;
					break;
				default:
					_ = 5;
					continue;
				case 2:
					obj2 = this;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 3:
					return;
				case 1:
					return;
				case 6:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 4:
					if (P_0 != 0)
					{
						obj = 3;
						break;
					}
					goto case 6;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00ᰀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778112, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00ᴀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778113, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00Ḁ(uint P_0)
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00ἀ(uint P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778126, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_2000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778127, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_2100()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0049->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008a->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				return;
			default:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj2 = ((object)this) ?? ((object)/*Error near IL_005b: Stack underflow*/);
				if (obj2 == null)
				{
					obj2 = (object)/*Error near IL_006e: Stack underflow*/;
				}
				if (false)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IRelayCommand<GameInstanceModel> _FF00_FF00_2200()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17850, 1790778124, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778124, new IntPtr(2737335806412L), 15);
		}
		return (IRelayCommand<GameInstanceModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_FF00_2300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778125, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_FF00_2400()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0052: Expected I4, but got Obj
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected I4, but got Unknown
		//IL_00c3->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0088->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0097->IL0019: Incompatible stack types: I4 vs Obj
		//IL_011a->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00ce->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b3->IL0019: Incompatible stack heights: 2 vs 1
		//IL_018b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0143->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0125->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016f->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014e->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 9:
			case 12:
				obj = this;
				obj2 = 11;
				continue;
			case 4:
				return;
			case 2:
			case 6:
			case 10:
			case 11:
				obj = obj;
				obj2 = 3;
				continue;
			case 3:
				if (4 != 0)
				{
					_ = 2;
				}
				continue;
			case 1:
				obj = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			default:
				switch (obj - 1)
				{
				case 0:
					goto IL_0125;
				case 1:
					goto IL_014e;
				case 2:
					goto end_IL_0019;
				}
				if (12 == 0)
				{
					obj2 = 5;
				}
				continue;
			case 8:
				goto IL_0125;
			case 7:
				goto IL_014e;
			case 5:
				break;
				IL_014e:
				obj = ((object)this) ?? ((object)/*Error near IL_0160: Stack underflow*/);
				obj2 = 10;
				continue;
				IL_0125:
				obj = ((object)this) ?? ((object)/*Error near IL_0132: Stack underflow*/);
				if (2 == 0)
				{
					obj2 = 2;
				}
				continue;
				end_IL_0019:
				break;
			}
			obj = ((object)this) ?? ((object)/*Error near IL_017c: Stack underflow*/);
			obj2 = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte _FF00_FF00_2500()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00_FF00_2600()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778122, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00_FF00_2700()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal uint _FF00_FF00_2800()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (uint)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe uint _FF00_FF00_2900()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778123, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (uint)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_2A00(ObservableCollection<GameInstanceModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0096->IL003b: Incompatible stack heights: 1 vs 0
		//IL_0055->IL0019: Incompatible stack heights: 3 vs 1
		//IL_008c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				_ = 5;
				break;
			case 5:
				_ = 4;
				break;
			case 1:
				return;
			case 2:
				return;
			case 4:
				obj2 = this;
				if (1 == 0)
				{
					obj2 = 0;
				}
				break;
			case 3:
				obj2 = this;
				if (P_0 != null)
				{
					if (true)
					{
						obj2 = 2;
					}
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FF00_2B00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_0065->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0048->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 1:
				obj2 = P_0;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
				return;
			default:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 2;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00_FF00Ⰰ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778120, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00ⴀ(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778121, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FF00_2E00(object P_0)
	{
		//IL_0029: Expected Obj, but got I
		//IL_0059: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17862, 1790778134, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 2, 1790778134, new IntPtr(2737335814732L), 15);
		}
		return ((delegate*<object, object, object>)obj)(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<GameInstanceModel> _FF00_FF00_2F00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<GameInstanceModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<GameInstanceModel> _FF00_FF00_3000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778135, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<GameInstanceModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<GameInstanceModel> _FF00_FF00_3100()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17865, 1790778132, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778132, new IntPtr(2737335802252L), 15);
		}
		return (IAsyncRelayCommand<GameInstanceModel>)((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe IAsyncRelayCommand<GameInstanceModel> _FF00_FF00_3200()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778133, new IntPtr(2737335815772L), 15))(null, 0, new IntPtr(0L));
		return (IAsyncRelayCommand<GameInstanceModel>)/*Error near IL_0033: Stack underflow*/;
	}
}
