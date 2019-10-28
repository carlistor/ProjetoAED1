using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

class Empreendedor {
  private string id_Empreendedor;
  private string nome;
  private string cnpj;
  private string telefone;
  private string SetorAtuacao;
  private Endereco MeuEndereco;
  private Empresa EmpresaNova;

  public Empreendedor(string i, string n, string c, string t, string s ){
    id_Empreendedor = i;
    nome = n;
    cnpj = c;
    telefone = t;
    SetorAtuacao = s;
    this.MeuEndereco = new Endereco();
    this.EmpresaNova = new Empresa();
  }
  public Empreendedor(){
    id_Empreendedor = "00";
    nome = "nova Empresa";
    cnpj = "0000";
    telefone ="0000-0000";
    SetorAtuacao = "tudo";
  }
  public string getNome(){
    return nome;
  }
  public void setNome(string n){
    this.nome = n;
  }
  public string getTelefone(){
    return telefone;
  }
  public void setTelefone(string tel){
    telefone = tel;
  }
  public Empresa getEmpresaNova(){
    return EmpresaNova;
  }
  public Endereco getMeuEndereco(){
    return MeuEndereco;
  }
  public string getSetorAtuacao(){
    return SetorAtuacao;
  }
  public void setSetorAtuacao(string setor){
    SetorAtuacao = setor;    
  }
  public string getId_Empreendedor(){
    return id_Empreendedor;
  }
  public void setId_Empreendedor(string Id){
    id_Empreendedor = Id;
  }
 

  public void SelecionarFornecedor(){
    FileStream meuArq = new FileStream("EmpresaCadastradas.txt", FileMode.Open, FileAccess.Read);
    StreamReader reader = new StreamReader(meuArq, Encoding.UTF8);
    List<string> RamodeNegocio = new List<string>();
    List<string> id = new List<string>();
    while(!reader.EndOfStream){
        string linha = reader.ReadLine();        
        string[] valores = linha.Split('|');
        id.Add(valores[0]);
        RamodeNegocio.Add(valores[1]);

      }
      for (int i=0; i<RamodeNegocio.Count;i++){
        Console.WriteLine("ID Empresa: "+ id[i] +" - Setor : "+ RamodeNegocio[i]);
      }
    
      //Enquanto não chegar ao final do arquivo:
      /*while(!reader.EndOfStream){
      string str = reader.ReadLine();
      
        Console.WriteLine(str);
      }*/
      reader.Close();
      meuArq.Close();    
  }
  //public 
}
