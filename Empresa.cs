using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
/*ID_empresa, NomeEmpresa, Endereco, telefone, SetorAtuacao*/
class Empresa{
  private string ID_empresa;
  private string NomeEmpresa;
  private string telefone;
  private string SetorAtuacao;
  private Endereco MeuEndereco;
  private Empreendedor MeuEmpreendedor;

  public Empresa(){
    ID_empresa = "000";
    NomeEmpresa = " ";
    telefone = "00000000000";
    SetorAtuacao = " ";
  }
  public Empresa( string id, string nome, string tel, string setor){
    ID_empresa = id;
    NomeEmpresa = nome;
    telefone = tel;
    SetorAtuacao = setor;
    this.MeuEndereco = new Endereco();
    this.MeuEmpreendedor = new Empreendedor();
    //gravar aqruivo de texto com id da empresa e setor
    FileStream arq = new FileStream("EmpresaCadastradas.txt" ,FileMode.Append, FileAccess.Write);
    StreamWriter sw = new StreamWriter(arq, Encoding.UTF8);
    List<string> dados = new List<string>(){SetorAtuacao,"|",ID_empresa,"|"};

     foreach(var item in dados){
      sw.Write(item);
      
    }
    sw.WriteLine(" ");

    sw.Close();
    arq.Close();
  }
  //endereço
  public Endereco getMeuEndereco(){
    return MeuEndereco;
  }
  //ID da empresa
  public string getId_Empresa(){
    return ID_empresa;
  }
  public void setID_empresa(string id){
    ID_empresa = id;
  }

  //nome da Empresa
  public string getNomeEmpresa(){
    return NomeEmpresa;
  }
  public void setNomeEmpresa(string nome){
    NomeEmpresa = nome;
  }
  public string getTelefone(){
    return telefone;
  }
  public void setTelefone(string tel){
    telefone = tel;
  }
  public string getSetorAtuacao(){
    return SetorAtuacao;
  }
  public void setSetorAtuacao(string setor){
    SetorAtuacao = setor;    
  }
  
  public void CadastrarEmpreendedor(Empreendedor MeuEmpreendedor){

      //Manipulador:
      FileStream meuArq = new FileStream("Mei.txt", FileMode.Append, FileAccess.Write);
      //Escritor para o arquivo:
      StreamWriter sw = new StreamWriter(meuArq, Encoding.UTF8);
      string str = string.Empty;
      str = MeuEmpreendedor.getTelefone();
       //Realiza a gravação da linha de texto dentro do arquivo:
      sw.WriteLine(str);
      str = MeuEmpreendedor.getNome();
      sw.WriteLine(str);
      sw.Close();
      meuArq.Close();
    }

}