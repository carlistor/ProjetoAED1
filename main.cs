using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
    Empreendedor BBQ = new Empreendedor("001","BBQ", "127.576.567-08", "988484960","Comercio");
    BBQ.getMeuEndereco().setRua("Pinga da Boa");
    BBQ.getMeuEndereco().setNumero("51");
    BBQ.getMeuEndereco().setBairro("Cachaça não falta");
    BBQ.getMeuEndereco().setMunicipio("Pinguso");
    BBQ.getMeuEndereco().setEstado("CanaBraba");
    BBQ.getMeuEndereco().setPais("Brasil");
    Empreendedor Carlos = new Empreendedor("002","Carlos", "127.576.567-08","995174985", "Industria");
    Carlos.getMeuEndereco().setRua("Pinga da Boa");
    Carlos.getMeuEndereco().setNumero("51");
    Carlos.getMeuEndereco().setBairro("Cachaça não falta");
    Carlos.getMeuEndereco().setMunicipio("Pinguso");
    Carlos.getMeuEndereco().setEstado("CanaBraba");
    Carlos.getMeuEndereco().setPais("Brasil");
    Representante MeuRepresentante = new Representante("9000","Carlistor", "988020547");
    Empresa MinhaEmpresa = new Empresa("001", "FRICAO", "2730314512" , "Comercio" );
    Empresa OutraEmpresa = new Empresa("002", "RIGOCAO", "2730544512" , "Industria" );
    MinhaEmpresa.CadastrarEmpreendedor(BBQ);
    MinhaEmpresa.CadastrarEmpreendedor(Carlos);
        Console.WriteLine();
    Carlos.SelecionarFornecedor();
    
  }
}