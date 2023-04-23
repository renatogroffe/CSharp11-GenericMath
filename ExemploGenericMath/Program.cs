using System.Runtime.InteropServices;
using System.Text.Json;
using ExemploGenericMath;

Console.WriteLine("***** Testes com C# 11 | Generic Math *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();

var transacoes01 = new double[] { 100.05, -10.72, 20.0, -21.0, 37.47 };
var totalEntradas01 = SaldoBancario.CalcularConsolidado<double>(transacoes01, true);
var totalSaidas01 = SaldoBancario.CalcularConsolidado<double>(transacoes01, false);
Console.WriteLine($"{nameof(transacoes01)} = {JsonSerializer.Serialize(transacoes01)} [{transacoes01.GetType().FullName}]");
Console.WriteLine($"{nameof(totalEntradas01)} = {totalEntradas01:0.00} [{totalEntradas01.GetType().FullName}]");
Console.WriteLine($"{nameof(totalSaidas01)} = {totalSaidas01:0.00} [{totalSaidas01.GetType().FullName}]");

Console.WriteLine();

var transacoes02 = new decimal[] { 10.0m, -13.0m, 20.82m, -24.53m, 33.17m };
var totalEntradas02 = SaldoBancario.CalcularConsolidado<decimal>(transacoes02, true);
var totalSaidas02 = SaldoBancario.CalcularConsolidado<decimal>(transacoes02, false);
Console.WriteLine($"{nameof(transacoes02)} = {JsonSerializer.Serialize(transacoes02)} [{transacoes02.GetType().FullName}]");
Console.WriteLine($"{nameof(totalEntradas02)} = {totalEntradas02:0.00} [{totalEntradas02.GetType().FullName}]");
Console.WriteLine($"{nameof(totalSaidas02)} = {totalSaidas02:0.00} [{totalSaidas02.GetType().FullName}]");