using System.Runtime.InteropServices;
using System.Text;
using System;

public class JamSDK {
    [DllImport("jam_sdk")]
    private unsafe static extern char* set_env_path(char* path);

    [DllImport("jam_sdk")]
    private unsafe static extern char* get_cluster_name();

    [DllImport("jam_sdk")]
    private unsafe static extern char* get_connection_host();

    [DllImport("jam_sdk")]
    private unsafe static extern char* get_display_name();

    [DllImport("jam_sdk")]
    private unsafe static extern char* get_player_idx();

    [DllImport("jam_sdk")]
    private unsafe static extern char* get_session_id();

    [DllImport("jam_sdk")]
    private unsafe static extern char* get_user_session_id();

    static string ConvertToString(System.IntPtr input)
    {
        int len = 0;
        while (Marshal.ReadByte(input, len) != 0) { ++len; }
        byte[] buffer = new byte[len];
        Marshal.Copy(input, buffer, 0, buffer.Length);
        return Encoding.UTF8.GetString(buffer);
    }

    unsafe public static void SetEnvPath(string path) 
    {
        set_env_path((char*)Marshal.StringToHGlobalAnsi(path));
    }

    unsafe public static string ClusterName()
    {
        return ConvertToString((System.IntPtr)get_cluster_name());
    }
    
    unsafe public static string ConnectionHost()
    {
        return ConvertToString((System.IntPtr)get_connection_host());
    }

    unsafe public static int PlayerIdx()
    {
        return Int32.Parse(
            ConvertToString((System.IntPtr)get_player_idx())
        );
    }

    unsafe public static string SessionID()
    {
        return ConvertToString((System.IntPtr)get_session_id());
    }
    
    unsafe public static string UserSessionID()
    {
        return ConvertToString((System.IntPtr)get_user_session_id());
    }
}