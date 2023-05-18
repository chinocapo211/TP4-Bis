public class Pais{
    public string nombre{get;}
    public string imgBandera{get;}
    public int poblacion{get;}
    public DateTime fechaIndependencia{get;}
    public string atractivosTuristicos{get;}
    
    public Pais(string nom, string img, int pob, DateTime fecha, string atrac){
        nombre = nom;
        imgBandera= img;
        poblacion = pob;
        fechaIndependencia = fecha;
        atractivosTuristicos = atrac;
    }
} 