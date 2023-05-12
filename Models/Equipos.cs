public static class Equipos
{
public static List<string> ListaEquipos {get; private set;} = new List<string>() {"Libertad de Wilde", "All Boys", "Patronato", "Aldosivi", "Chacarita", "Atlanta", "Ferro", "River Plate", "Chaco For Ever", "Yupanqui", "Berazategui"};
public static List<string> ListaMedias {get; private set;} = new List<string>() {"MediasAzules.jpg", "MediasNegras.jpg", "MediasRojas.jpg", "MediasAmarillas.jpg", "MediasVerdes.jpg", "MediasBlancas.jpg", "MediasNaranjas.jpg"};
public static List<string> ListaPantalones {get; private set;} = new List<string>() {"PantalonAzul.jpg", "PantalonNegro.jpg", "PantalonRojo.jpg", "PantalonAmarillo.jpg", "PantalonVerde.jpg", "PantalonBlanco.jpg", "PantalonNaranja.jpg"};
public static List<string> ListaRemeras {get; private set;} = new List<string>() {"RemeraAzul.jpg", "RemeraNegra.jpg", "RemeraRoja.jpg", "RemeraAmarilla.jpg", "RemeraVerde.jpg", "RemeraBlanca.jpg", "RemeraNaranja.jpg"};
public static Dictionary<string, indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary<string, indumentaria>();

public static bool IngresarIndumentaria (string EquipoSeleccionado, indumentaria item)
{ 
    bool devolver = false;
    if(!EquiposIndumentaria.ContainsKey(EquipoSeleccionado))
    {
        EquiposIndumentaria.Add(EquipoSeleccionado, item);
        devolver = true;
    }
    return devolver;
}
}

