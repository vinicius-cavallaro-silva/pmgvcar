using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
//using PMGVcar.Model.ModelCarro;


namespace PMGVcar
{
    //OleDbConnection banco
    class CarroDao
    {
        string banco = "C:\\Users\\gomes\\source\repos\\PMGVcar\\BD\\PMGVcar.xls";

        // conexao = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="+banco+"; Extended Properties =’Excel 12.0 Xml; HDR = YES’;");
        //conexao = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + banco +" ; Extended Properties = 'Excel 8.0;HDR=YES;ReadOnly=False'")
    }


}
