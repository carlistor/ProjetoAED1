using System;
class Endereco{
  private string Rua;
  private string Numero;
  private string Bairro;
  private string Municipio;
  private string Estado;
  private string Pais;
  public Endereco(){
    Rua = " ";
    Numero = " ";
    Bairro = " ";
    Municipio = " ";
    Estado = " ";
    Pais = "Brasil";
  }
  public Endereco(string r, string n, string b, string m, string e, string p){
    Rua = r;
    Numero = n;
    Bairro = b;
    Municipio = m;
    Estado = e;
    Pais = p;
  }
  public string getRua(){
    return Rua;
  }
  public void setRua(string r){
    Rua = r;
  }
  public string getNumero(){
    return Numero;
  }
  public void setNumero(string n){
    Numero = n;
  }
  public string getBairro(){
    return Bairro;
  }
  public void setBairro(string b){
    Bairro = b;
  }
  public string getMunicipio(){
    return Municipio;
  }
  public void setMunicipio(string m){
   Municipio = m;
  }
  public string getEstado(){
    return Estado;
  }
  public void setEstado(string e){
    Estado = e;
  }
  public string getPais(){
    return Pais;
  }
  public void setPais(string p){
    Pais =p;
  }
 /* public string etiqueta(){
   Console.WriteLine("Rua : {0}");
   Console.WriteLine("Rua : {0}");

  }*/
  public override string ToString()
        {
            return String.Format("Endereço: Rua: {0}, Nº:({1}) Bairro: {2}, Municipio: {3}, Estado: {4}, País: {5} ", this.Rua, this.Numero, this.Bairro, this.Municipio, this.Estado, this.Pais);
           
        }
}