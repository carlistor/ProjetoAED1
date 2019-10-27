using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

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
  public Endereco getMeuEndereco(){
    return MeuEndereco;
  }
  public string getSetorAtuacao(){
    return SetorAtuacao;
  }
  public void setSetorAtuacao(string setor){
    SetorAtuacao = setor;    
  }
  public void SelecionarFornecedor(){
    FileStream meuArq = new FileStream("EmpresaCadastradas.txt", FileMode.Open, FileAccess.Read);
    StreamReader reader = new StreamReader(meuArq, Encoding.UTF8);
    List<string> nomes = new List<string>();
    List<string> id = new List<string>();
      while(!reader.EndOfStream){
        string linha = reader.ReadLine();
        /*if(getSetorAtuacao()== linha){
          Console.WriteLine(linha);
        }*/
        //Console.WriteLine(linha);
        string[] valores = linha.Split('|');
        //nomes.Add(linha);
        nomes.Add(valores[0]);
        id.Add(valores[1]);
      }
      for (int i=0; i<nomes.Count;i++){
        Console.WriteLine("Setor: "+ nome +" - ID Empresa: "+ id);
      }
      reader.Close();
      meuArq.Close();
    
    
  }
}
