using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MaquinaDeCalcular.AppCode
{
    public static class DigitosDecimais
    {
        static public SelectList ListaDigitosDecimais(int ndd = 6)
        {
            List<SelectListItem> ListaNumDig = new List<SelectListItem>();

            for (int p = 0; p <= ndd; p++)
                ListaNumDig.Add(new SelectListItem
                {
                    Text = $"Digitos Decimais [{p.ToString()}",
                    Value = p.ToString()
                });

            return new SelectList(ListaNumDig, "Value", "Text");
        }
    }
}
