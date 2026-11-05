using System;

class MuestraBiologica
{
    private string codigoMuestra;
    private double temperaturaActual;
    private bool estaAptas;

    public MuestraBiologica(string codigoMuestra, double temperaturaActual, bool estaAptas)
    {
        this.codigoMuestra = codigoMuestra;
        this.temperaturaActual = temperaturaActual;

        if(temperaturaActual < -80 || temperaturaActual > 8)
        {
            estaAptas = false;
            System.Console.WriteLine("ALERTA : TEMPERATURA DE MUESTRA PELIGROSA O NO APTA");
        }
        
    }

    public MuestraBiologica()
    {
        codigoMuestra = "000";
        temperaturaActual = 0.0;
        estaAptas = true;
    }
}
