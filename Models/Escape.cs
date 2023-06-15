namespace TP5;
using System.Collections.Generic;
public static class Escape
{

private static string[] incognitasSalas = new string[5];
private static int estadoJuego = 1;

private static void InicializarJuego()
{
    incognitasSalas[0]="";
    incognitasSalas[1] = "vampiro";
    incognitasSalas[2] = "551";
    incognitasSalas[3] = "casa embrujada";
    incognitasSalas[4] = "27";
}
public static int GetEstadoJuego()
{
    return estadoJuego;
}
public static bool ResolverSala(int Sala, string Incognita)
{
    if (estadoJuego == 1)
    {
        InicializarJuego();
    }
    if (Sala > estadoJuego)
    {
        return false;
    }
    else{
        if(Incognita == incognitasSalas[Sala])
        {
            estadoJuego++;
            return true;
        }
        else{
            return false;
        }
    }
}
}