using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal class ISteamGameServerStats : SteamInterface
	{
		public override IntPtr GetInterfacePointer() => GetApi.SteamGameServerStats();
		
		
		internal ISteamGameServerStats()
		{
			SetupInterface();
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServerStats_RequestUserStats")]
		private static extern SteamAPICall_t _RequestUserStats( IntPtr self, SteamId steamIDUser );
		
		#endregion
		internal CallbackResult<GSStatsReceived_t> RequestUserStats( SteamId steamIDUser )
		{
			var returnValue = _RequestUserStats( Self, steamIDUser );
			return new CallbackResult<GSStatsReceived_t>( returnValue );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserStat")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _GetUserStat( IntPtr self, SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, ref int pData );
		
		#endregion
		internal bool GetUserStat( SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, ref int pData )
		{
			var returnValue = _GetUserStat( Self, steamIDUser, pchName, ref pData );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserStat")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _GetUserStat( IntPtr self, SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, ref float pData );
		
		#endregion
		internal bool GetUserStat( SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, ref float pData )
		{
			var returnValue = _GetUserStat( Self, steamIDUser, pchName, ref pData );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserAchievement")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _GetUserAchievement( IntPtr self, SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, [MarshalAs( UnmanagedType.U1 )] ref bool pbAchieved );
		
		#endregion
		internal bool GetUserAchievement( SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, [MarshalAs( UnmanagedType.U1 )] ref bool pbAchieved )
		{
			var returnValue = _GetUserAchievement( Self, steamIDUser, pchName, ref pbAchieved );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserStat")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _SetUserStat( IntPtr self, SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, int nData );
		
		#endregion
		internal bool SetUserStat( SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, int nData )
		{
			var returnValue = _SetUserStat( Self, steamIDUser, pchName, nData );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserStat")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _SetUserStat( IntPtr self, SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, float fData );
		
		#endregion
		internal bool SetUserStat( SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, float fData )
		{
			var returnValue = _SetUserStat( Self, steamIDUser, pchName, fData );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServerStats_UpdateUserAvgRateStat")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _UpdateUserAvgRateStat( IntPtr self, SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, float flCountThisSession, double dSessionLength );
		
		#endregion
		internal bool UpdateUserAvgRateStat( SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName, float flCountThisSession, double dSessionLength )
		{
			var returnValue = _UpdateUserAvgRateStat( Self, steamIDUser, pchName, flCountThisSession, dSessionLength );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserAchievement")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _SetUserAchievement( IntPtr self, SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName );
		
		#endregion
		internal bool SetUserAchievement( SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName )
		{
			var returnValue = _SetUserAchievement( Self, steamIDUser, pchName );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServerStats_ClearUserAchievement")]
		[return: MarshalAs( UnmanagedType.I1 )]
		private static extern bool _ClearUserAchievement( IntPtr self, SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName );
		
		#endregion
		internal bool ClearUserAchievement( SteamId steamIDUser, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchName )
		{
			var returnValue = _ClearUserAchievement( Self, steamIDUser, pchName );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServerStats_StoreUserStats")]
		private static extern SteamAPICall_t _StoreUserStats( IntPtr self, SteamId steamIDUser );
		
		#endregion
		internal CallbackResult<GSStatsStored_t> StoreUserStats( SteamId steamIDUser )
		{
			var returnValue = _StoreUserStats( Self, steamIDUser );
			return new CallbackResult<GSStatsStored_t>( returnValue );
		}
		
	}
}