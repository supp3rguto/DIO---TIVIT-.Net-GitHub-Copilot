using CoreApi.Models;
using System.Text.RegularExpressions;

namespace CoreApi.Services;

public class CardService {
    public CardResult VerificarCartao(string numeroCartao) {
        if (string.IsNullOrWhiteSpace(numeroCartao))
            return new CardResult(false, "Desconhecida", "Número vazio.");

        var numero = numeroCartao.Replace(" ", "").Replace("-", "");

        if (!long.TryParse(numero, out _))
             return new CardResult(false, "Desconhecida", "Contém caracteres inválidos.");

        bool luhnValido = ValidarLuhn(numero);

        if (!luhnValido) {
            return new CardResult(false, IdentificarBandeira(numero), "Número inválido pelo algoritmo de Luhn.");
        }

        string bandeira = IdentificarBandeira(numero);

        return new CardResult(true, bandeira, "Cartão válido.");
    }

    private string IdentificarBandeira(string numero) {
        if (numero.StartsWith("4011") || numero.StartsWith("4312") || numero.StartsWith("4389"))
            return "Elo";

        if (numero.StartsWith("4"))
            return "Visa";

        if (numero.Length >= 2) {
            int prefixo2 = int.Parse(numero.Substring(0, 2));
            if (prefixo2 >= 51 && prefixo2 <= 55) return "MasterCard";
        }
        
        if (numero.Length >= 4) {
            int prefixo4 = int.Parse(numero.Substring(0, 4));
            if (prefixo4 >= 2221 && prefixo4 <= 2720) return "MasterCard";
        }

        if (numero.StartsWith("34") || numero.StartsWith("37"))
            return "American Express";

        if (numero.StartsWith("6011") || numero.StartsWith("65"))
            return "Discover";
            
        if (numero.Length >= 3) {
             int prefixo3 = int.Parse(numero.Substring(0, 3));
             if (prefixo3 >= 644 && prefixo3 <= 649) return "Discover";
        }

        if (numero.StartsWith("6062"))
            return "Hipercard";

        return "Desconhecida";
    }

    private bool ValidarLuhn(string numero) {
        int soma = 0;
        bool deveDuplicar = false;

        for (int i = numero.Length - 1; i >= 0; i--) {
            int digito = numero[i] - '0';

            if (deveDuplicar) {
                digito *= 2;
                if (digito > 9) 
                    digito -= 9;
            }

            soma += digito;
            deveDuplicar = !deveDuplicar;
        }

        return (soma % 10) == 0;
    }
}