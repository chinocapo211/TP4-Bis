    public static class info
{
    static List<Pais> listaPaises = new List<Pais>();
    private static void inicializarLista()
    {
        DateTime fecha = new DateTime (1816,6,9);
        Pais pais = new Pais("Argentina", "ar.png", 45810000, fecha, "Obelisco");
        listaPaises.Add(pais);
        fecha = new DateTime (1991,12,16);
        pais = new Pais("Kazajistán", "k.png", 19000000, fecha, "Bayterek");
        listaPaises.Add(pais);
        fecha = new DateTime (1927,5,20);
        pais = new Pais("Arabia Saudita", "a.png", 35950000, fecha, "Fuente del Rey Fahd");
        listaPaises.Add(pais);
        fecha = new DateTime (1948,5,14);
        pais = new Pais("Israel", "i.png", 9364000, fecha, "Fortaleza de Metzada");
        listaPaises.Add(pais);
        fecha = new DateTime (1991,9,1);
        pais = new Pais("Uzbekistán", "u.png", 34920000, fecha, "Registán");
        listaPaises.Add(pais);
    }
    public static List<Pais> listarPaises(){
        if(listaPaises.Count() == 0){
            inicializarLista();
        }
        return listaPaises;
    }
    static public Pais DetallePais(string nombrePais)
    {
        for(int i = 0; i < listaPaises.Count(); i++){
            if(listaPaises[i].nombre == nombrePais){
                return listaPaises[i];
            }
        }
        return null;
    }
}