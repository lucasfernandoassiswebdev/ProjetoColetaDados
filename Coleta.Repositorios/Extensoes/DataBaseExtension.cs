using System;
using System.Data.SqlClient;

namespace Coleta.Repositorios.Extensoes
{
    public static class DataBaseExtension
    {
        public static int ReadAsInt(this SqlDataReader r, string name)
        {
            return r.GetInt32(r.GetOrdinal(name));
        }

        public static string ReadAsString(this SqlDataReader r, string name)
        {
            return r.GetString(r.GetOrdinal(name));
        }

        public static DateTime ReadAsDate(this SqlDataReader r, string name)
        {
            return r.GetDateTime(r.GetOrdinal(name));
        }
    }
}
