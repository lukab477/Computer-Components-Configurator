using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacunalneKomponente
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += (sender, e) => ObrisiNepotpuneKonfiguracije();
            Application.Run(new frmMenu());
        }
        public static void ObrisiNepotpuneKonfiguracije()
        {
            string connectionString = "Server=31.147.206.65;Database=RWA2517_DB;User Id=RWA2517_User;Password=pV_Y4JPk;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string deleteQuery = @"DELETE FROM KorisnikoveKonfiguracije
                    WHERE ISNULL(Procesor, '') = ''
                      AND ISNULL(Graficka, '') = ''
                      AND ISNULL(MaticnaPloca, '') = ''
                      AND ISNULL(RAM, '') = ''
                      AND ISNULL(Pohrana, '') = ''
                      AND ISNULL(Napajanje, '') = ''
                      AND ISNULL(Kuciste, '') = ''";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.ExecuteNonQuery();
                }
            }
        }
    }

}
