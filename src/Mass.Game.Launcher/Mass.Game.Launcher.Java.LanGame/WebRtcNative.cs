using System.Runtime.InteropServices;

namespace Mass.Game.Launcher.Java.LanGame;

public static class WebRtcNative
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void SuccessCallback(string peerId, string type, string sdp);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void FailureCallback(string peerId, string message);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void ErrorCallback(string peerId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void IceCandidateCallback(string peerId, string mid, int index, string sdp);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DataBinaryMessageCallback(string peerId, nint dataPtr, int length);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DataMessageCallback(string peerId, string message);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DataChannelStateChangeCallback(string peerId);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern nint CreateConductor(string peerId);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void DeleteConductor(nint conductorPtr);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void Quit(nint conductorPtr);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void Run(nint conductorPtr);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void InitializeSSL();

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void CleanupSSL();

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern bool InitializePeerConnection(nint conductorPtr);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void CreateOffer(nint conductorPtr);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void CreateAnswer(nint conductorPtr);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void ProcessMessages(nint conductorPtr, int delayMs);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void CreateDataChannel(nint conductorPtr, string label);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void AddServerConfig(nint conductorPtr, string url, string username, string password);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void OnOfferRequest(nint conductorPtr, string sdp);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void OnOfferReply(nint conductorPtr, string type, string sdp);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool GetChannelReady(nint conductorPtr);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern nint GetCandidateType(nint conductorPtr);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool AddIceCandidate(nint conductorPtr, string mid, int index, string sdp);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool DataChannelSendText(nint conductorPtr, string text);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool DataChannelSendData(nint conductorPtr, byte[] data, int length);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void RegisterOnSuccessCallback(nint conductorPtr, SuccessCallback callback);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void RegisterOnFailureCallback(nint conductorPtr, FailureCallback callback);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void RegisterOnErrorCallback(nint conductorPtr, ErrorCallback callback);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void RegisterOnIceCandidateCallback(nint conductorPtr, IceCandidateCallback callback);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void RegisterOnDataBinaryMessageCallback(nint conductorPtr, DataBinaryMessageCallback callback);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void RegisterOnDataMessageCallback(nint conductorPtr, DataMessageCallback callback);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void RegisterOnDataChannelStateChangeCallback(nint conductorPtr, DataChannelStateChangeCallback callback);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void RegisterOnDataChannelOpenCallback(nint conductorPtr, DataChannelStateChangeCallback callback);

	[DllImport("Mass.WebRtc.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern void RegisterOnDataChannelCloseCallback(nint conductorPtr, DataChannelStateChangeCallback callback);
}
