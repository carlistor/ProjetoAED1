using System.IO;
using System.Collections.Generic;

  class Representante {
    private string id_Representante;
    private string nome;
    private string telefone;
    
    public Representante(string i, string n, string t) {
      id_Representante = i;
      nome = n;
      telefone = t;
    }
    public Representante(){
      id_Representante ="24";
      nome = "Daneil";
      telefone = "69243155";
    }
    public string getId_representante(){
      return id_Representante;            
    }
    public void setId_Representante(string IdNumero){
      id_Representante = IdNumero;
    }
    public string getNome(){
      return nome;
    }
    public string getTelefone(){
      return telefone;
    }
  }