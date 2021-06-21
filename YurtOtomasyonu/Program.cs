using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new OgrenciForm());
           // Application.Run(new FrmOgrDuzenle());
           //Application.Run(new FrmAnaForm());
           Application.Run(new FrmAdminGiris());
           // Application.Run(new FrmYoneticiDuzenle());
            //Application.Run(new FrmBolumler());
            //Application.Run(new FrmGiderListesi());
        }
    }
}
