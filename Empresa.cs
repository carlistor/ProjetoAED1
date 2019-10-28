using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
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
    SetorAtuacao = "Comercio";
  }
  public Empresa( string id, string nome, string tel, string setor){
    ID_empresa = id;
    NomeEmpresa = nome;
    telefone = tel;
    SetorAtuacao = setor;
    this.MeuEndereco = new Endereco();
    this.MeuEmpreendedor = new Empreendedor();
    //gravar aqruivo de texto com id da empresa e setor
    
    /*FileStream arq = new FileStream("EmpresaCadastradas.txt" ,FileMode.Append, FileAccess.Write);
    StreamWriter sw = new StreamWriter(arq, Encoding.UTF8);
    List<string> dados = new List<string>(){ID_empresa ,"|",SetorAtuacao,"|", NomeEmpresa,"|",telefone};

     foreach(var item in dados){
      sw.Write(item);
      
    }
    sw.WriteLine(" ");

    sw.Close();
    arq.Close();*/
        //Ler arquivo 
    FileStream meuArq = new FileStream("EmpresaCadastradas.txt", FileMode.Open, FileAccess.Read);
    StreamReader reader = new StreamReader(meuArq, Encoding.UTF8);
    List<string> ID_cadas = new List<string>();
   
    while(!reader.EndOfStream){
        string linha = reader.ReadLine();        
        string[] valores = linha.Split("|");
        ID_cadas.Add(linha);
      }
      for (int i=0; i<ID_cadas.Count;i++){
        if(ID_empresa != ID_cadas[i]){
           //GRavar arquivo 
          FileStream arq = new FileStream("EmpresaCadastradas.txt" ,FileMode.Append, FileAccess.Write);
          StreamWriter sw = new StreamWriter(arq, Encoding.UTF8);
          List<string> dados = new List<string>(){ID_empresa ,"|",SetorAtuacao,"|", NomeEmpresa,"|",telefone};

          foreach(var item in dados){
          sw.Write(item);     
          }
          sw.WriteLine(" ");
          sw.Close();
          arq.Close();

        }else{
          Console.WriteLine("Empresa ja Cadastrada");
        }
        
      }
      reader.Close();
      meuArq.Close();
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
      if (MeuEmpreendedor.getSetorAtuacao() == SetorAtuacao){
        //Manipulador:
        FileStream meuArq = new FileStream("Mei.txt", FileMode.Append, FileAccess.Write);        
        //Escritor para o arquivo:
        StreamWriter sw = new StreamWriter(meuArq, Encoding.UTF8);
        string str = string.Empty;
        
        //Realiza a gravação da linha de texto dentro do arquivo:
        List<string> dados = new List<string>(){MeuEmpreendedor.getId_Empreendedor(),"|",MeuEmpreendedor.getNome(),"|",MeuEmpreendedor.getMeuEndereco().getMunicipio(),"|",MeuEmpreendedor.getTelefone()};

          foreach(var item in dados){
            sw.Write(item);
            
          }
          sw.WriteLine("");
        sw.Close();
        meuArq.Close();
      }else
      {
        Console.Write("{0} :Empreendedor Não e compativel ao setor de atuação" ,MeuEmpreendedor.getNome());
      }      
    }
    /*public void CadastrarRepresentante(Representante UmRepresentante){
      //Manipulador:
        FileStream meuArq = new FileStream("RepresentanteCadastrado.txt", FileMode.Append, FileAccess.Write);        
        //Escritor para o arquivo:
        StreamWriter sw = new StreamWriter(meuArq, Encoding.UTF8);
        string str = string.Empty;
        
        //Realiza a gravação da linha de texto dentro do arquivo:
        List<string> dados = new List<string>(){UmRepresentante.getId_representante(),"|",UmRepresentante.getNome(),"|",UmRepresentante.getMeuEndereco().getMunicipio(),"|",UmRepresentante.getTelefone()};

          foreach(var item in dados){
            sw.Write(item);
            
          }
          sw.WriteLine("");
        sw.Close();
        meuArq.Close();
      
    }*/


}