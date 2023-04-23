using System.Numerics;

namespace ExemploGenericMath;

public static class SaldoBancario
{
    public static T CalcularConsolidado<T>(T[] transacoes, bool entradas) where T: INumber<T>
    {
        var consolidado = T.Zero;
        foreach (var transacao in transacoes)
        {
            if ((entradas & transacao > T.Zero) ||
                (!entradas & transacao < T.Zero))
                consolidado += transacao;
        }
        return consolidado;
    }
}
