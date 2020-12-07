using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace Facturation
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            Facture fac1 = new Facture("Bouygues","FAC001-123","02/01/2019","01/03/2019",1000,500);
            Facture fac2 = new Facture("Jean Pastis","FAC023-008","15/06/2016","20/06/2016",800,800);
            Facture fac3 = new Facture("Baptise chevrier","FAC195-054","24/09/2015","06/10/2015",150,100);
            Facture fac4 = new Facture("Léon pelo","FAC199-158","13/12/2015","01/01/2016",1500,1500);
            Facture fac5 = new Facture("Théo david","FAC454-665","28/11/2014","05/12/2014",800,800);


            List<Facture> factures = new List<Facture>();
            factures.Add(fac1);
            factures.Add(fac2);
            factures.Add(fac3);
            factures.Add(fac4);
            factures.Add(fac5);
            builder.Services.AddTransient(f => factures);
            builder.Services.AddScoped(
                sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

            await builder.Build().RunAsync();
        }
        
        
    }
}