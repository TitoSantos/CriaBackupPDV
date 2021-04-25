using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CriaBackupPDV.Enums;
using System.IO;


namespace CriaBackupPDV.Entities
{
    class Arquivo
    {
        public Clientes Clientes { get; set; }
        public int Versao { get; set; }
        public int NumeroDraft { get; set; }
        const string DiretorioOrigem = @"C:\\p2k";

        public Arquivo()
        {
                
        }

        public Arquivo(Clientes clientes, int versao, int numeroDraft)
        {
            Clientes = clientes;
            Versao = versao;
            NumeroDraft = numeroDraft;
        }

        private string DiretorioBackup()
        {
            int clientes = (int)Clientes;
            string diretorioBackup;

            switch (clientes)
            {
                case 0:
                    diretorioBackup = @"C:\\_AUTOMACAO\\_BACKUP\\DPSP\\PDV";
                    break;
                case 1:
                    diretorioBackup = @"C:\\_AUTOMACAO\\_BACKUP\\EXTRAFARMA\\PDV";
                    break;
                case 2:
                    diretorioBackup = @"C:\\_AUTOMACAO\\_BACKUP\\RENNER\\PDV";
                    break;
                case 3:
                    diretorioBackup = @"C:\\_AUTOMACAO\\_BACKUP\\TIM\\PDV";
                    break;
                default:
                    diretorioBackup = "Vazio";
                    break;
            }
            return diretorioBackup;
        }

        public void CriaBackup()
        {
            string diretorio = DiretorioBackup();
            DirectoryInfo origem = new DirectoryInfo(DiretorioOrigem);
            DirectoryInfo destino = new DirectoryInfo(diretorio);

            if (!destino.Exists)
            {
                Directory.CreateDirectory(diretorio);

            }
     
        
        }


    }
}
