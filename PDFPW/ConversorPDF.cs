using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PDFPW
{
    public class ConversorPDF
    {
        public static async Task Coverter()
        {
            using var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false,
                    SlowMo = 50,
                    //ExecutablePath = @"C:\Users\adria\AppData\Local\ms-playwright\chromium-930007\chrome-win\chrome.exe"
                    ExecutablePath = @"C:\Users\adria\AppData\Local\ms-playwright\chrome-win\chrome.exe"
                });
            var page = await browser.NewPageAsync();
            //await page.GotoAsync("https://www.theverge.com");
            await page.GotoAsync("file:///C:/temp/pdf/teste.html");
            await page.PdfAsync(new PagePdfOptions
            {
                DisplayHeaderFooter = false,
                FooterTemplate =  null,
                Format = PaperFormat.A4,
                HeaderTemplate = null,
                Height = null,
                Width = null,
                Landscape = true,
                Margin= new Margin() { Top = "0", Bottom = "0", Left = "0", Right = "0" },
                Path = @"C:\temp\\pdf\saida.pdf",
                PrintBackground = true
            }); //page.ScreenshotAsync(new() { Path = "theverge.png" });


            //using var playwright = await Playwright.CreateAsync();

            //// Inicie o navegador (por padrão, inicia o navegador Chromium)
            //var browser = await playwright.Chromium.LaunchAsync(
            //    new BrowserTypeLaunchOptions
            //    {
            //        Headless = false,
            //        SlowMo = 50,
            //        //ExecutablePath = @"C:\Users\adria\AppData\Local\ms-playwright\chromium-930007\chrome-win\chrome.exe"
            //        ExecutablePath = @"C:\Users\adria\AppData\Local\ms-playwright\chrome-win\chrome.exe"
            //    });

            //// Crie uma nova página no navegador
            //var page = await browser.NewPageAsync();

            //// Navegue até uma URL específica
            //await page.GotoAsync("https://www.google.com");

            //// Verifique se a instância de 'page' não é nula
            //if (page != null)
            //{
            //    // Chame o método PdfAsync
            //    var pdfBytes = await page.PdfAsync();

            //    // Salve o arquivo PDF
            //    File.WriteAllBytes("output.pdf", pdfBytes);
            //}
            //else
            //{
            //    Console.WriteLine("Falha ao criar a instância da página.");
            //}

            //// Feche o navegador
            //await browser.CloseAsync();





            //using var playwright = await Playwright.CreateAsync();
            //{
            //    await using var browser = await playwright.Chromium.LaunchAsync(new Microsoft.Playwright.BrowserTypeLaunchOptions
            //    {
            //        Headless = false,
            //        SlowMo = 50,
            //        //ExecutablePath = @"C:\Users\adria\AppData\Local\ms-playwright\chromium-930007\chrome-win\chrome.exe"
            //        ExecutablePath = @"C:\Users\adria\AppData\Local\ms-playwright\chrome-win\chrome.exe"
            //    });
            //    {
            //        var context = await browser.NewContextAsync();

            //        var page = await context.NewPageAsync();
            //        await page.GotoAsync("https://www.google.com");


            //        await Task.Delay(3000);


            //        var pdfPath = "C:\\temp\\pdf\\saida.pdf";
            //        //await page.PdfAsync(new PagePdfOptions { Path = pdfPath, Format = PaperFormat.A4, Landscape = true });

            //        try
            //        {
            //            var pdfBytes = await page.PdfAsync();
            //            File.WriteAllBytes(pdfPath, pdfBytes);
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }

            //        await browser.CloseAsync();
            //    }
            //}

            //var pdfOptions = new PagePdfOptions
            //{
            //    Path = "saida_personalizada.pdf", // Substitua pelo nome desejado do arquivo PDF de saída
            //    Format = PaperFormat.A4,
            //    Landscape = true,
            //    DisplayHeaderFooter = true,
            //    HeaderTemplate = "<div style='font-size: 10px; margin-left: 10px;'>Cabeçalho da Página</div>",
            //    FooterTemplate = "<div style='font-size: 10px; margin-right: 10px;'>Rodapé da Página</div>"
            //    // Outras opções podem ser configuradas conforme necessário
            //};

            //var playwrightOptions = new BrowserFetcherOptions
            //{
            //    Path = "ms-playwright",
            //    //Platform = Platform.Windows,
            //    Revision = "1097" // Substitua pela versão específica que você está usando
            //};

            //using var playwright = await Playwright.CreateAsync();
            //var firefox = playwright.Firefox;
            //var browser = await firefox.LaunchAsync(new() { Headless = false });

            //var page = await browser.NewPageAsync();
            //await page.GotoAsync("https://www.bing.com");
            //await browser.CloseAsync();


            //using var playwright = await Playwright.CreateAsync();
            //var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { ExecutablePath  });

            //var page = await browser.NewPageAsync();

            //// Substitua 'C:\\temp\\pdf\\chartbar.html' pelo caminho do seu arquivo HTML local
            //var htmlPath = "C:\\temp\\pdf\\chartbar.html";
            //var htmlContent = await File.ReadAllTextAsync(htmlPath);

            //await page.SetContentAsync(htmlContent);

            //// Substitua 'C:\\temp\\pdf\\saida.pdf' pelo caminho do arquivo PDF de saída desejado
            //var pdfPath = "C:\\temp\\pdf\\saida.pdf";
            //await page.PdfAsync(new PagePdfOptions { Path = pdfPath, Format = PaperFormat.A4 });

            //await browser.CloseAsync();
















            //using var playwright = await Playwright.CreateAsync();

            //var browser = await playwright.Chromium.LaunchAsync(new() { Headless = true });

            //var page = await browser.NewPageAsync();
            //await page.GoToAsync("https://www.chartjs.org/docs/latest/samples/line/line.html");
            //// Substitua 'seu_arquivo.html' pelo caminho do seu arquivo HTML local
            ////var htmlPath = @"C:\temp\pdf\chartbar.html";  //Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "seu_arquivo.html");
            ////var htmlContent = await File.ReadAllTextAsync(htmlPath);

            ////await page.SetContentAsync(htmlContent);

            //// Substitua 'saida.pdf' pelo nome desejado do arquivo PDF de saída
            ////var pdfPath = @"C:\temp\pdf\saida.pdf"; //Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saida.pdf");
            ////await page.GetPdfAsync(new  PagePdfOptions { Path = pdfPath, Format = PaperFormat.A4 });


            ////var pdfOptions = new PagePdfOptions
            ////{
            ////    Path = "saida_personalizada.pdf", // Substitua pelo nome desejado do arquivo PDF de saída
            ////    Format = PaperFormat.A4,
            ////    Landscape = true,
            ////    DisplayHeaderFooter = true,
            ////    HeaderTemplate = "<div style='font-size: 10px; margin-left: 10px;'>Cabeçalho da Página</div>",
            ////    FooterTemplate = "<div style='font-size: 10px; margin-right: 10px;'>Rodapé da Página</div>"
            ////    // Outras opções podem ser configuradas conforme necessário
            ////};

            //// string path = "", decimal scale = 1m, bool displayHeaderFooter = false, string headerTemplate = "", string footerTemplate = "", bool printBackground = false, bool landscape = false, string pageRanges = "", PaperFormat? format = null, string width = null, string height = null, Margin margin = null, bool preferCSSPageSize = false

            //// Obter o conteúdo em PDF da página
            //var pdfBytes = await page.GetPdfAsync();

            //// Salvar o conteúdo em PDF em um arquivo
            //await File.WriteAllBytesAsync(@"C:\temp\pdf\saida.pdf", pdfBytes);




            //await browser.CloseAsync();
        }





        //    var playwrightOptions = new BrowserFetcherOptions
        //    {
        //        Path = "ms-playwright",
        //        Platform = Platform.Windows,
        //        Revision = "1097" // Substitua pela versão específica que você está usando
        //    };

        //    var playwright = await Playwright.CreateAsync(playwrightOptions);
        //    var browser = await playwright.Chromium.LaunchAsync();

        //    var page = await browser.NewPageAsync();

        //    // Substitua 'C:\\temp\\pdf\\chartbar.html' pelo caminho do seu arquivo HTML local
        //    var htmlPath = "C:\\temp\\pdf\\chartbar.html";
        //    var htmlContent = await File.ReadAllTextAsync(htmlPath);

        //    await page.SetContentAsync(htmlContent);

        //    // Substitua 'C:\\temp\\pdf\\saida.pdf' pelo caminho do arquivo PDF de saída desejado
        //    var pdfPath = "C:\\temp\\pdf\\saida.pdf";
        //    await page.PdfAsync(new PagePdfOptions { Path = pdfPath, Format = PaperFormat.A4
        //});

        //    await browser.CloseAsync();

    }
}
