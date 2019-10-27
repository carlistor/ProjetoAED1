using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
    Empreendedor BBQ = new Empreendedor("001","BBQ", "127.576.567-08", "988484960","Comercio");
    Empreendedor Carlos = new Empreendedor("002","Carlos", "127.576.567-08","995174985", "Industria");
    Representante MeuRepresentante = new Representante("9000","Carlistor", "988020547");
    Empresa MinhaEmpresa = new Empresa("001", "FRICAO", "2730314512" , "Comercio" );
    Empresa OutraEmpresa = new Empresa("002", "RIGOCAO", "2730544512" , "Industria" );
    MinhaEmpresa.CadastrarEmpreendedor(BBQ);
    MinhaEmpresa.CadastrarEmpreendedor(Carlos);
    Carlos.SelecionarFornecedor();
  }
}