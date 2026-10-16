using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mass.Domain.Desktop.Entities.Mods;
using Mass.Domain.Desktop.Interfaces;
using Mass.WinUI.Models;
using WinRT;
using WinRT.Mass_WinUIVtableClasses;

namespace Mass.WinUI.ViewModels;

[WinRTExposedType(typeof(Mass_WinUI_Models_DesktopGameCharacterModelWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
public class GameResourceViewModel : ObservableObject, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadCoreResources_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GameResourceViewModel _003C_003E4__this;

		private object _003C_003E8__1;

		private IEnumerable<GameResourceModel> _003Cmodels_003E5__2;

		private TaskAwaiter<EntityGameModsHash> _003C_003Eu__1;

		private TaskAwaiter<EntityItemDownload> _003C_003Eu__2;

		internal static object DecorateControllableTracer;

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
		internal static bool ReflectTransferableResolver()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ReflectResponsiveDecryptor()
		{
			throw new Exception("Error, DNGuard Runtime library not loaded!");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00舀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778310, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00茀()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0579: Expected Obj, but got Ref
			//IL_0594: Expected Obj, but got Ref
			//IL_00b7: Expected Obj, but got I4
			//IL_0208: Expected Obj, but got Ref
			//IL_029c: Expected Obj, but got I4
			//IL_0217: Expected Obj, but got Ref
			//IL_027c: Expected Obj, but got I4
			//IL_0251: Expected Obj, but got Ref
			//IL_0321: Expected Obj, but got I4
			//IL_01fa: Expected Obj, but got Ref
			//IL_01af: Expected Obj, but got I4
			//IL_02c6: Expected Obj, but got I4
			//IL_0585->IL0019: Incompatible stack heights: 0 vs 1
			//IL_05a0->IL0019: Incompatible stack heights: 0 vs 1
			//IL_05b8->IL0019: Incompatible stack heights: 2 vs 1
			//IL_004b->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0590->IL0019: Incompatible stack types: I4 vs Obj
			//IL_05ab->IL0019: Incompatible stack types: I4 vs Obj
			//IL_0056->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0077->IL007b: Incompatible stack heights: 1 vs 0
			//IL_0492->IL007b: Incompatible stack heights: 1 vs 0
			//IL_04ce->IL007b: Incompatible stack heights: 2 vs 0
			//IL_0475->IL007b: Incompatible stack heights: 1 vs 0
			//IL_007b->IL007b: Incompatible stack heights: 3 vs 0
			//IL_0212->IL00df: Incompatible stack heights: 1 vs 0
			//IL_01a3->IL00df: Incompatible stack heights: 1 vs 0
			//IL_00db->IL00df: Incompatible stack heights: 1 vs 0
			//IL_03a3->IL00df: Incompatible stack heights: 2 vs 0
			//IL_0175->IL00df: Incompatible stack heights: 3 vs 0
			//IL_031c->IL00df: Incompatible stack heights: 3 vs 0
			//IL_02a7->IL00df: Incompatible stack heights: 3 vs 0
			//IL_0297->IL00df: Incompatible stack heights: 4 vs 0
			//IL_01ea->IL00df: Incompatible stack heights: 2 vs 0
			//IL_02b6->IL00df: Incompatible stack heights: 2 vs 0
			//IL_0287->IL00df: Incompatible stack heights: 3 vs 0
			//IL_01da->IL00df: Incompatible stack heights: 2 vs 0
			//IL_02fb->IL00df: Incompatible stack heights: 4 vs 0
			//IL_032e->IL00df: Incompatible stack heights: 2 vs 0
			//IL_0204->IL00df: Incompatible stack heights: 1 vs 0
			//IL_037e->IL00df: Incompatible stack heights: 2 vs 0
			//IL_0396->IL00df: Incompatible stack heights: 3 vs 0
			//IL_03ae->IL03b4: Incompatible stack types: Obj vs Ref
			//IL_02e0->IL00df: Incompatible stack heights: 1 vs 0
			//IL_02d1->IL00df: Incompatible stack heights: 3 vs 0
			//IL_036e->IL00df: Incompatible stack heights: 1 vs 0
			//IL_01f5->IL00df: Incompatible stack heights: 2 vs 0
			//IL_02c1->IL00df: Incompatible stack heights: 2 vs 0
			//IL_022e->IL00df: Incompatible stack heights: 1 vs 0
			//IL_0268->IL00df: Incompatible stack heights: 1 vs 0
			//IL_0339->IL00df: Incompatible stack heights: 2 vs 0
			//IL_030d->IL00df: Incompatible stack heights: 1 vs 0
			//IL_0389->IL00df: Incompatible stack heights: 2 vs 0
			//IL_02eb->IL00df: Incompatible stack heights: 1 vs 0
			//IL_00df->IL00df: Incompatible stack heights: 2 vs 0
			//IL_0400->IL00df: Incompatible stack heights: 4 vs 0
			//IL_024d->IL00df: Incompatible stack heights: 1 vs 0
			//IL_035a->IL00df: Incompatible stack heights: 1 vs 0
			//IL_040b->IL00df: Incompatible stack heights: 4 vs 0
			//IL_03d3->IL00df: Incompatible stack heights: 3 vs 0
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			object obj = 1;
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 5:
					_ = -2;
					if (false)
					{
						_ = 2;
					}
					break;
				case 3:
					return;
				case 4:
					if ((nuint)(nint)obj <= (nuint)1u)
					{
						if (0 == 0)
						{
							_ = 0;
						}
						goto IL_007b;
					}
					goto IL_0475;
				default:
					obj = (object)Unsafe.AsPointer(ref this);
					if (4 != 0)
					{
						obj2 = 3;
					}
					break;
				case 1:
					obj = (object)Unsafe.AsPointer(ref this);
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				case 2:
					{
						_ = 3;
						break;
					}
					IL_0475:
					if ((int)/*Error near IL_047b: Stack underflow*/ != 0)
					{
						if (false)
						{
							_ = 1;
						}
						goto IL_007b;
					}
					goto case 5;
					IL_007b:
					while (true)
					{
						switch ((int)/*Error near IL_00a4: Stack underflow*/)
						{
						case 4:
						case 8:
							break;
						case 3:
							_ = null;
							obj = 8;
							continue;
						case 2:
							if (obj == null)
							{
								if (29 != 0)
								{
									_ = 18;
								}
								goto IL_00df;
							}
							goto IL_0191;
						default:
							_ = 2;
							continue;
						case 5:
							goto IL_0475;
						case 6:
							goto IL_04bd;
							IL_00df:
							while (true)
							{
								switch ((int)/*Error near IL_0160: Stack underflow*/)
								{
								case 6:
									return;
								case 25:
									return;
								case 2:
									_ = 9;
									continue;
								case 1:
									break;
								case 27:
									obj = 12;
									continue;
								case 14:
									obj = obj;
									_ = 20;
									continue;
								case 8:
									if (15 == 0)
									{
										_ = 14;
									}
									continue;
								case 19:
									obj = (object)(&obj);
									_ = 4;
									continue;
								case 11:
									goto IL_0204;
								case 10:
									obj = (object)(&obj);
									if (24 != 0)
									{
										_ = 13;
									}
									continue;
								case 17:
									if (&obj == null)
									{
										if (28 == 0)
										{
											_ = 24;
										}
										continue;
									}
									goto case 19;
								case 13:
								case 29:
									obj = (object)Unsafe.AsPointer(ref this);
									if (false)
									{
										_ = 0;
									}
									continue;
								case 12:
									obj = -1;
									_ = 19;
									continue;
								case 7:
									_ = ref obj;
									_ = 25;
									continue;
								case 5:
									obj = -1;
									_ = 10;
									continue;
								case 9:
									_ = null;
									if (14 != 0)
									{
										_ = 22;
									}
									continue;
								case 28:
									obj = 1;
									_ = 8;
									continue;
								case 26:
									if (30 == 0)
									{
										_ = 19;
									}
									continue;
								case 15:
									_ = ref obj;
									_ = 6;
									continue;
								case 20:
									if (&obj == null)
									{
										_ = 16;
										continue;
									}
									goto case 10;
								case 4:
									_ = 3;
									continue;
								case 16:
									obj = 0;
									if (16 == 0)
									{
										_ = 21;
									}
									continue;
								case 18:
									if ((nint)obj == 2)
									{
										if (17 == 0)
										{
											_ = 26;
										}
										continue;
									}
									goto case 2;
								case 30:
									obj = obj;
									_ = 17;
									continue;
								case 21:
									if (7 == 0)
									{
										_ = 1;
									}
									continue;
								case 23:
									_ = null;
									_ = 2;
									continue;
								default:
									_ = 5;
									continue;
								case 24:
								{
									object obj3 = obj;
									ref _003CLoadCoreResources_003Ed__36 reference2 = ref *(_003CLoadCoreResources_003Ed__36*)obj3;
									if (obj3 == null)
									{
										reference2 = ref this;
									}
									if (Unsafe.AsPointer(ref reference2) == null)
									{
										reference2 = ref this;
									}
									_ = 18;
									continue;
								}
								case 3:
								{
									ref _003CLoadCoreResources_003Ed__36 reference = ref this;
									if (Unsafe.AsPointer(ref reference) == null)
									{
										reference = ref this;
									}
									if (23 == 0)
									{
										_ = 13;
									}
									continue;
								}
								case 22:
									goto IL_04bd;
								}
								break;
							}
							goto IL_0191;
							IL_04bd:
							_ = 3;
							continue;
							IL_0191:
							if ((nint)obj != 1)
							{
								_ = 14;
								goto IL_00df;
							}
							goto IL_0204;
							IL_0204:
							obj = (object)Unsafe.AsPointer(ref this);
							_ = 27;
							goto IL_00df;
						}
						break;
					}
					goto case 5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static byte _FF00_FF00_FF00_FF00_FF00萀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778311, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
			return (byte)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte _FF00_FF00_FF00_FF00_FF00蔀()
		{
			//IL_0009: Invalid comparison between Unknown and Obj
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object _FF00_FF00_FF00_FF00_FF00蘀()
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
			}
			return (object)/*Error near IL_0009: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static object _FF00_FF00_FF00_FF00_FF00蜀()
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778308, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
			return (object)/*Error near IL_0033: Stack underflow*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sealed void _FF00_FF00_FF00_FF00_FF00蠀(object P_0)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0026: Expected I4, but got Obj
			//IL_003c->IL0019: Incompatible stack heights: 2 vs 1
			//IL_0047->IL0019: Incompatible stack heights: 2 vs 1
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
				case 0:
					return;
				case 1:
					if (0 == 0)
					{
						_ = 0;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe sealed void _FF00_FF00_FF00_FF00_FF00褀(object P_0)
		{
			//IL_0008: Expected I8, but got I4
			((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778309, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
			_ = null;
		}
	}

	private object _tag;

	private readonly object _watcher;

	private object _basePath;

	private object _currentPath;

	private object _modsPath;

	private object _resourcePacksPath;

	private object _shaderPacksPath;

	private object _allowPaths;

	private object _game;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? refreshCollectionCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? loadCoreResourcesCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? loadCollectionCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private object? openFolderCommand;

	internal static GameResourceViewModel DecorateCommonContainer;

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ObservableProperty]
	public ObservableCollection<GameResourceModel> CoreResources
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00쐀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00쬀(value);
		}
	}

	[ObservableProperty]
	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	public ObservableCollection<GameResourceModel> AllResources
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_ED00();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00툀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public ObservableCollection<GameResourceModel> Resources
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00턀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00쌀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	[ObservableProperty]
	public bool IsDragging
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00_E900() != 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00뼀(value ? ((byte)1) : ((byte)0));
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string SearchText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (string)_FF00_E600();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00케(value);
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public object? SelectedItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return _FF00뜀();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			_FF00섀(value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand RefreshCollectionCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00윀();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand LoadCoreResourcesCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IAsyncRelayCommand)this._FF00_FFFD();
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand LoadCollectionCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00_E700();
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	public IRelayCommand OpenFolderCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (IRelayCommand)_FF00묀();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameResourceViewModel()
	{
		//IL_009a: Expected I4, but got Obj
		//IL_0080->IL0089: Incompatible stack types: I4 vs Obj
		//IL_00ad->IL0089: Incompatible stack heights: 14 vs 13
		//IL_00c8->IL0089: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		GameResourceViewModel gameResourceViewModel = this;
		if (true)
		{
			gameResourceViewModel = (GameResourceViewModel)0;
		}
		while (true)
		{
			switch ((int)gameResourceViewModel)
			{
			default:
				_ = 2;
				break;
			case 1:
				gameResourceViewModel = this;
				if (0 == 0)
				{
					gameResourceViewModel = (GameResourceViewModel)0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(IDesktopGame game)
	{
		_FF00_FFFD(game);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FileChanged(object sender, object args)
	{
		_FF00눀(sender, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_FF00꼀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void RefreshCollection()
	{
		_FF00대();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	[AsyncStateMachine(typeof(_003CLoadCoreResources_003Ed__36))]
	private object LoadCoreResources()
	{
		return _FF00_FFFD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void LoadCollection()
	{
		_FF00봀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RelayCommand]
	private void OpenFolder()
	{
		_FF00뤀();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DragStatusChanged(byte isDragging)
	{
		_FF00저(isDragging);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FilesDropped(object files)
	{
		_FF00_E100(files);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ValidResource(object file)
	{
		_FF00_EB00(file);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnSelectedItemChanged(object? value)
	{
		_FF00촀(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DecorateAdaptableConverter()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GameResourceViewModel CheckPortableVerifier()
	{
		throw new Exception("Error, DNGuard Runtime library not loaded!");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00글()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778268, new IntPtr(2737335824092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal sealed void _FF00꼀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003e: Expected I4, but got Obj
		//IL_00dd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_006f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_005d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_007a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00d0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00b5->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 6;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				if (0 == 0)
				{
					_ = 0;
				}
				break;
			case 2:
				_ = 4;
				break;
			case 4:
				_ = 3;
				break;
			case 6:
				obj2 = this;
				if (5 == 0)
				{
					obj2 = 5;
				}
				break;
			case 5:
				obj2 = this;
				if (2 == 0)
				{
					obj2 = 1;
				}
				break;
			case 7:
				return;
			case 1:
				_ = 7;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe sealed void _FF00뀀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778269, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00넀(object P_0, object P_1)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778266, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00눀(object P_0, object P_1)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0047->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00대()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0232: Expected Obj, but got I4
		//IL_023c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_021e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 0 vs 1
		//IL_020e->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0229->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0057->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014d->IL006b: Incompatible stack heights: 1 vs 0
		//IL_0131->IL006b: Incompatible stack heights: 1 vs 0
		//IL_0178->IL006b: Incompatible stack heights: 3 vs 0
		//IL_00a8->IL0112: Incompatible stack heights: 1 vs 0
		//IL_00ca->IL0169: Incompatible stack heights: 1 vs 0
		//IL_00fb->IL0169: Incompatible stack heights: 1 vs 0
		//IL_00b4->IL006b: Incompatible stack heights: 1 vs 0
		//IL_00d6->IL006b: Incompatible stack heights: 1 vs 0
		//IL_0107->IL006b: Incompatible stack heights: 1 vs 0
		//IL_00bf->IL006b: Incompatible stack heights: 1 vs 0
		//IL_00e1->IL006b: Incompatible stack heights: 1 vs 0
		//IL_0112->IL006b: Incompatible stack heights: 1 vs 0
		//IL_0196->IL006b: Incompatible stack heights: 1 vs 0
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 4:
				obj = this;
				if (1 == 0)
				{
					obj2 = 3;
				}
				break;
			case 3:
				while (true)
				{
					if (obj == null)
					{
						if (8 == 0)
						{
							_ = 9;
						}
						goto IL_006b;
					}
					goto IL_0131;
					IL_0131:
					obj = obj;
					if (2 == 0)
					{
						_ = 2;
					}
					goto IL_006b;
					IL_006b:
					while (true)
					{
						switch ((int)/*Error near IL_0098: Stack underflow*/)
						{
						case 2:
							if (this == null)
							{
								if (4 != 0)
								{
									_ = 7;
								}
								continue;
							}
							break;
						case 4:
							if (obj == null)
							{
								if (5 == 0)
								{
									_ = 8;
								}
								continue;
							}
							goto default;
						case 6:
							if (obj == null)
							{
								if (0 == 0)
								{
									_ = 4;
								}
								continue;
							}
							goto default;
						case 5:
						case 8:
							break;
						case 3:
							goto IL_0131;
						default:
							_ = 5;
							continue;
						case 7:
							if (obj == null)
							{
								if (0 == 0)
								{
									_ = 0;
								}
								continue;
							}
							goto case 6;
						case 9:
							return;
						}
						break;
					}
				}
			case 5:
				_ = 4;
				break;
			case 2:
				obj = this;
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				obj = obj == null;
				obj2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00됀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778267, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static object _FF00딀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778264, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object _FF00똀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (object)/*Error near IL_0009: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00뜀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00렀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778265, new IntPtr(2737335823052L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00뤀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0045->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 1;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00먀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778342, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00묀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17748, 1790778343, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778343, new IntPtr(2737335823052L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00봀()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_0044->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0070->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0082->IL0082: Incompatible stack heights: 4 vs 3
		//IL_004f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ae->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b9->IL0019: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				_ = null;
				if (false)
				{
					_ = 0;
				}
				break;
			case 1:
				obj2 = (object)this - (object)this;
				if (3 != 0)
				{
					obj2 = 0;
				}
				break;
			case 2:
			{
				GameResourceViewModel gameResourceViewModel = this;
				if (gameResourceViewModel == null)
				{
					_ = null;
				}
				if (gameResourceViewModel == null)
				{
					gameResourceViewModel = this;
				}
				if (gameResourceViewModel == null)
				{
					gameResourceViewModel = this;
				}
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00븀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778340, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00뼀(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0082->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0042->IL0037: Incompatible stack heights: 1 vs 0
		//IL_009a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0073->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0059->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				return;
			case 2:
				obj2 = this;
				if (P_0 != 0)
				{
					return;
				}
				if (true)
				{
					obj2 = 1;
				}
				break;
			case 1:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			default:
				if (2 == 0)
				{
					_ = 4;
				}
				break;
			case 4:
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00쀀(byte P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778341, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00섀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0048->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0094->IL0048: Incompatible stack heights: 1 vs 0
		//IL_0056->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0070->IL0019: Incompatible stack types: I4 vs Obj
		//IL_008a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_009e->IL0019: Incompatible stack heights: 2 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				_ = 5;
				break;
			case 1:
				return;
			case 5:
				_ = 2;
				break;
			case 2:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 1;
				}
				break;
			case 3:
				obj2 = this;
				if (false)
				{
					obj2 = 0;
				}
				break;
			case 4:
				if (P_0 != null)
				{
					return;
				}
				_ = 3;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00숀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778338, new IntPtr(2737335799132L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00쌀(ObservableCollection<GameResourceModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_0081->IL0019: Incompatible stack heights: 2 vs 1
		//IL_009d->IL0015: Incompatible stack heights: 1 vs 0
		//IL_0041->IL009d: Incompatible stack heights: 1 vs 0
		//IL_008c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0072->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0058->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 3:
					obj2 = this;
					if (P_0 == null)
					{
						if (0 == 0)
						{
							obj2 = 2;
						}
						continue;
					}
					return;
				case 2:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				default:
					if (true)
					{
						_ = 1;
					}
					continue;
				case 1:
					break;
				case 4:
					return;
				}
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<GameResourceModel> _FF00쐀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<GameResourceModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<GameResourceModel> _FF00씀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778339, new IntPtr(2737335812652L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<GameResourceModel>)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00였()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778336, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00윀()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17760, 1790778337, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778337, new IntPtr(2737335824092L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00저(byte P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Expected I4, but got Obj
		//IL_0041->IL0019: Incompatible stack heights: 4 vs 1
		//IL_004c->IL0019: Incompatible stack heights: 4 vs 1
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
				/*Error near IL_002c: Stack underflow*/;
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
	internal static byte _FF00준()
	{
		//IL_0009: Invalid comparison between Unknown and Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return ((object)/*Error near IL_000b: Stack underflow*/ == null) ? ((byte)1) : ((byte)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static byte _FF00쨀()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778350, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00쬀(ObservableCollection<GameResourceModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_0088->IL003b: Incompatible stack heights: 1 vs 0
		//IL_007e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0055->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0092->IL0019: Incompatible stack heights: 2 vs 1
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
				obj2 = this;
				if (4 == 0)
				{
					obj2 = 4;
				}
				break;
			case 2:
				return;
			case 4:
				_ = 5;
				break;
			case 3:
				if (P_0 != null)
				{
					_ = 2;
					break;
				}
				goto default;
			case 1:
				return;
			case 5:
				obj2 = this;
				if (true)
				{
					obj2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00찀(ObservableCollection<GameResourceModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778351, new IntPtr(2737335820972L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00촀(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_00a7->IL0019: Incompatible stack heights: 4 vs 1
		//IL_004d->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005d->IL0019: Incompatible stack heights: 2 vs 1
		//IL_008b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0068->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00c0->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00b5->IL00b5: Incompatible stack heights: 1 vs 2
		//IL_0096->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 4:
				obj = P_0;
				obj2 = 3;
				break;
			case 6:
				_ = null;
				if (1 == 0)
				{
					_ = 1;
				}
				break;
			case 1:
				return;
			case 3:
				if (obj != null)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				return;
			case 2:
				_ = 6;
				break;
			case 5:
				return;
			default:
				if (obj == null)
				{
				}
				_ = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00츀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778348, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00케(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0036: Expected I4, but got Obj
		//IL_00af->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0045->IL005d: Incompatible stack heights: 1 vs 0
		//IL_00ba->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00a0->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0077->IL0019: Incompatible stack types: I4 vs Obj
		//IL_005c->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 5;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 5:
				obj2 = this;
				if (P_0 != null)
				{
					if (4 == 0)
					{
						obj2 = 2;
					}
					break;
				}
				goto case 3;
			case 2:
				return;
			case 4:
				return;
			case 3:
				obj2 = this;
				if (0 == 0)
				{
					obj2 = 0;
				}
				break;
			case 1:
				obj2 = this;
				if (2 != 0)
				{
					obj2 = 0;
				}
				break;
			default:
				if (1 == 0)
				{
					_ = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00퀀(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778349, new IntPtr(2737335798092L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<GameResourceModel> _FF00턀()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<GameResourceModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00툀(ObservableCollection<GameResourceModel> P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0032: Expected I4, but got Obj
		//IL_008c: Expected Obj, but got I4
		//IL_0078->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0083->IL0078: Incompatible stack heights: 1 vs 0
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0051->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0091->IL0015: Incompatible stack heights: 1 vs 0
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
				default:
					return;
				case 3:
					obj2 = this;
					if (1 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 2:
					obj2 = this;
					if (0 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 1:
					_ = 2;
					continue;
				case 0:
					return;
				case 4:
					if (P_0 != null)
					{
						return;
					}
					obj = 3;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe void _FF00팀(ObservableCollection<GameResourceModel> P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778346, new IntPtr(2737335802252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void _FF00_FFFD(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0072: Expected I4, but got Obj
		//IL_0189: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I4
		//IL_0201: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I4
		//IL_01f2->IL0019: Incompatible stack heights: 3 vs 1
		//IL_016a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_018e->IL0015: Incompatible stack heights: 2 vs 0
		//IL_0151->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0103->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01bd->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00ea->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00b1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_013f->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0111->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0131->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00d8->IL0019: Incompatible stack heights: 3 vs 1
		//IL_01d9->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00cb->IL0019: Incompatible stack heights: 3 vs 1
		//IL_019e->IL0019: Incompatible stack heights: 3 vs 1
		//IL_0120->IL0019: Incompatible stack heights: 2 vs 1
		//IL_017a->IL0019: Incompatible stack heights: 3 vs 1
		//IL_00a1->IL0019: Incompatible stack heights: 2 vs 1
		//IL_015c->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01c8->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0092->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00f5->IL0019: Incompatible stack heights: 2 vs 1
		//IL_00bc->IL0019: Incompatible stack heights: 2 vs 1
		//IL_01e4->IL0019: Incompatible stack heights: 2 vs 1
		//IL_022b->IL0019: Incompatible stack heights: 0 vs 1
		//IL_0236->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 13;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 6:
					_ = 1;
					if (9 == 0)
					{
						_ = 6;
					}
					continue;
				case 20:
					_ = 17;
					continue;
				case 8:
					_ = 1;
					if (14 == 0)
					{
						_ = 20;
					}
					continue;
				case 15:
					_ = 8;
					continue;
				case 13:
					_ = 12;
					continue;
				case 7:
					if (true)
					{
						_ = 2;
					}
					continue;
				case 4:
					_ = 1;
					_ = 10;
					continue;
				case 10:
					_ = 1;
					_ = 6;
					continue;
				case 17:
					_ = 14;
					continue;
				case 19:
					return;
				case 11:
					_ = 18;
					continue;
				case 9:
					_ = 1;
					_ = 5;
					continue;
				case 3:
					if (false)
					{
						_ = 0;
					}
					continue;
				case 1:
					_ = 1;
					_ = 11;
					continue;
				case 18:
					_ = 3;
					continue;
				case 2:
					break;
				case 16:
					_ = 7;
					continue;
				case 5:
					((object[])3)[0] = this;
					((object[])3)[1] = this;
					((object[])3)[2] = this;
					if (7 == 0)
					{
						_ = 15;
					}
					continue;
				case 14:
					_ = 19;
					if (0 == 0)
					{
						_ = 1;
					}
					continue;
				default:
					_ = null;
					_ = 19;
					continue;
				case 12:
				{
					((object[])5)[5] = 0;
					((object[])(object)this)[(object)this] = 1;
					_003F val = /*Error near IL_01fd: Stack underflow*/;
					((object[])/*Error near IL_0201: Stack underflow*/)[val] = 2;
					_003F val2 = /*Error near IL_0201: Stack underflow*/;
					((object[])/*Error near IL_0205: Stack underflow*/)[val2] = 3;
					((object[])/*Error near IL_0205: Stack underflow*/)[4] = (((nint)P_0 == 9) ? P_0 : P_0);
					if (14 == 0)
					{
						obj2 = 16;
					}
					continue;
				}
				}
				break;
			}
			obj = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778347, new IntPtr(2737335803292L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_FFFD()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17782, 1790778344, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778344, new IntPtr(2737335819932L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FFFD()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778345, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_FFFD()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17784, 1790778358, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778358, new IntPtr(2737335800172L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe object _FF00_E000()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778359, new IntPtr(2737335818892L), 15))(null, 0, new IntPtr(0L));
		return (object)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_E100(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		//IL_007d: Expected Obj, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_00b3: Expected I4, but got Obj
		//IL_007a->IL0019: Incompatible stack types: I4 vs Obj
		//IL_0160->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0087->IL0019: Incompatible stack types: I4 vs Obj
		//IL_014b->IL0019: Incompatible stack types: I4 vs Obj
		//IL_017c->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016b->IL0019: Incompatible stack heights: 2 vs 1
		//IL_005e->IL0019: Incompatible stack heights: 0 vs 1
		//IL_00a2->IL00a6: Incompatible stack types: I4 vs Obj
		//IL_0069->IL0019: Incompatible stack types: I4 vs Obj
		//IL_00cd->IL00a6: Incompatible stack heights: 3 vs 1
		//IL_00d8->IL00a6: Incompatible stack heights: 3 vs 1
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 4;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 5:
			case 6:
				if ((nint)obj >= ((Array)obj).Length)
				{
					if (0 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				obj = ((object[])obj)[obj];
				obj2 = 7;
				break;
			case 3:
				obj = 0;
				obj2 = 6;
				break;
			case 7:
			{
				object obj3 = obj;
				if (false)
				{
					obj3 = 0;
				}
				while (true)
				{
					switch ((int)obj3)
					{
					default:
						if (true)
						{
							_ = 0;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				goto case 2;
			}
			case 4:
				obj = P_0;
				obj2 = 3;
				break;
			case 2:
				_ = null;
				if (8 == 0)
				{
					_ = 8;
				}
				break;
			case 0:
				return;
			case 8:
				obj++;
				obj2 = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_E200(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778356, new IntPtr(2737335806412L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_E300()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778357, new IntPtr(2737335809532L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _FF00_E400()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002a: Expected I4, but got Obj
		//IL_003f->IL0019: Incompatible stack heights: 2 vs 1
		//IL_0054->IL004a: Incompatible stack heights: 1 vs 0
		//IL_004a->IL0019: Incompatible stack heights: 2 vs 1
		//IL_006b->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 2;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			default:
				return;
			case 1:
				_ = null;
				if (false)
				{
					_ = 0;
				}
				break;
			case 0:
				return;
			case 2:
				obj2 = this;
				if (null == null)
				{
					return;
				}
				if (1 == 0)
				{
					obj2 = 1;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void _FF00_E500()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778354, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal object _FF00_E600()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe object _FF00_E700()
	{
		//IL_0029: Expected Obj, but got I
		//IL_0058: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		nint num = (ZYXDNGuarder.a ?? throw new Exception("*=DVM Runtime error, missing dvm handler.=*"))(null, 17792, 1790778355, 0, 0);
		object obj = num;
		if (num == 0)
		{
			obj = ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 1, 1790778355, new IntPtr(2737335820972L), 15);
		}
		return ((delegate*<object, object>)obj)(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe byte _FF00_E800()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778352, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		return (byte)/*Error near IL_0033: Stack underflow*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte _FF00_E900()
	{
		//IL_000a: Expected I4, but got Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (byte)(int)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _FF00_EB00(object P_0)
	{
		//IL_0010: Expected Obj, but got I4
		//IL_002e: Expected I4, but got Obj
		//IL_004f->IL0053: Incompatible stack heights: 1 vs 0
		//IL_0161->IL0019: Incompatible stack heights: 0 vs 1
		//IL_014e->IL0019: Incompatible stack types: I4 vs Obj
		//IL_016c->IL0019: Incompatible stack types: I4 vs Obj
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		object obj = 3;
		object obj2 = obj;
		while (true)
		{
			switch ((int)obj2)
			{
			case 3:
				if (P_0 == null)
				{
					obj2 = 2;
				}
				else if (0 == 0)
				{
					obj2 = 0;
				}
				continue;
			case 1:
				return;
			case 2:
				throw /*Error near IL_0154: Stack underflow*/;
			}
			obj = P_0;
			if (1 == 0)
			{
				_ = 1;
			}
			switch ((int)/*Error near IL_0060: Stack underflow*/)
			{
			case 1:
				break;
			case 0:
				break;
			}
			return;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _FF00_EC00(object P_0)
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778353, new IntPtr(2737335828252L), 15))(null, 0, new IntPtr(0L));
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ObservableCollection<GameResourceModel> _FF00_ED00()
	{
		if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		return (ObservableCollection<GameResourceModel>)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe ObservableCollection<GameResourceModel> _FF00_EE00()
	{
		//IL_0008: Expected I8, but got I4
		((delegate* unmanaged[Stdcall]<AppDomain, int, nint, void>)ZYXDNGuarder.a(MethodBase.GetCurrentMethod(), 0, 1790778366, new IntPtr(2737335814732L), 15))(null, 0, new IntPtr(0L));
		return (ObservableCollection<GameResourceModel>)/*Error near IL_0033: Stack underflow*/;
	}
}
