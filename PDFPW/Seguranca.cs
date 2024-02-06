using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace PDFPW
{
    internal class Seguranca
    {
    }
}



//using System;
//using System.IO;
//using iText.Kernel.Pdf;
//using iText.Kernel.Pdf.Encryption;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Caminho para o arquivo PDF existente
//        string pdfFilePath = "existing_file.pdf";

//        // Caminho para o novo arquivo PDF protegido
//        string outputPdfPath = "output_protected.pdf";

//        // Senha para o usuário e senha do proprietário
//        string userPassword = "userPassword";
//        string ownerPassword = "ownerPassword";

//        // Permissões do PDF (permitir apenas impressão)
//        var permissions = EncryptionConstants.ALLOW_PRINTING;

//        // Aplicar proteção por senha ao PDF existente
//        ApplyPdfPasswordProtection(pdfFilePath, outputPdfPath, userPassword, ownerPassword, permissions);

//        Console.WriteLine("PDF protegido com sucesso!");
//    }

//    static void ApplyPdfPasswordProtection(string inputPdfPath, string outputPdfPath, string userPassword, string ownerPassword, int permissions)
//    {
//        // Abrir o PDF existente
//        using (var pdfReader = new PdfReader(inputPdfPath))
//        using (var pdfWriter = new PdfWriter(outputPdfPath))
//        {
//            // Configurar a proteção por senha
//            var encryptionProperties = new PdfEncryption();
//            encryptionProperties.SetUserPassword(System.Text.Encoding.UTF8.GetBytes(userPassword));
//            encryptionProperties.SetOwnerPassword(System.Text.Encoding.UTF8.GetBytes(ownerPassword));
//            encryptionProperties.AddPermissions(permissions);

//            // Aplicar a proteção por senha ao PDF
//            var pdfDocument = new PdfDocument(pdfReader, pdfWriter);
//            pdfDocument.SetEncryption(encryptionProperties);
//        }
//    }
//}


//using PdfSharp.Pdf;
//using PdfSharp.Pdf.IO;
//using PdfSharp.Security;
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string inputPdfPath = "existing_file.pdf"; // Caminho para o arquivo PDF existente
//        string outputPdfPath = "output_protected.pdf"; // Caminho para o novo arquivo PDF protegido
//        string userPassword = "userPassword"; // Senha do usuário
//        string ownerPassword = "ownerPassword"; // Senha do proprietário

//        // Crie um novo documento PDF
//        PdfDocument outputDocument = new PdfDocument();

//        // Abra o documento PDF existente
//        PdfDocument inputDocument = PdfReader.Open(inputPdfPath, PdfDocumentOpenMode.Import);

//        // Copie todas as páginas do documento existente para o novo documento
//        foreach (PdfPage page in inputDocument.Pages)
//        {
//            outputDocument.AddPage(page);
//        }

//        // Defina as configurações de segurança
//        PdfSecuritySettings securitySettings = outputDocument.SecuritySettings;
//        securitySettings.UserPassword = userPassword;
//        securitySettings.OwnerPassword = ownerPassword;
//        securitySettings.PermitAccessibilityExtractContent = false;
//        securitySettings.PermitAnnotations = false;
//        securitySettings.PermitAssembleDocument = false;
//        securitySettings.PermitExtractContent = false;
//        securitySettings.PermitFormsFill = false;
//        securitySettings.PermitFullQualityPrint = false;
//        securitySettings.PermitModifyDocument = false;
//        securitySettings.PermitPrint = true; // Permitir impressão

//        // Salve o novo documento PDF protegido
//        outputDocument.Save(outputPdfPath);

//        Console.WriteLine("PDF protegido com sucesso!");
//    }
//}



//using System;
//using System.IO;
//using iText.Kernel.Pdf;
//using iText.Kernel.Pdf.Encryption;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Caminho para o arquivo PDF existente
//        string pdfFilePath = "existing_file.pdf";

//        // Caminho para o novo arquivo PDF protegido
//        string outputPdfPath = "output_protected.pdf";

//        // Senha para o usuário e senha do proprietário
//        string userPassword = "userPassword";
//        string ownerPassword = "ownerPassword";

//        // Permissões do PDF (somente leitura)
//        var permissions = EncryptionConstants.ALLOW_PRINTING;

//        // Aplicar proteção por senha com permissões restritas ao PDF existente
//        ApplyPdfPasswordProtection(pdfFilePath, outputPdfPath, userPassword, ownerPassword, permissions);

//        Console.WriteLine("PDF protegido como somente leitura com sucesso!");
//    }

//    static void ApplyPdfPasswordProtection(string inputPdfPath, string outputPdfPath, string userPassword, string ownerPassword, int permissions)
//    {
//        // Abrir o PDF existente
//        using (var pdfReader = new PdfReader(inputPdfPath))
//        using (var pdfWriter = new PdfWriter(outputPdfPath))
//        {
//            // Configurar a proteção por senha
//            var encryptionProperties = new PdfEncryption();
//            encryptionProperties.SetUserPassword(System.Text.Encoding.UTF8.GetBytes(userPassword));
//            encryptionProperties.SetOwnerPassword(System.Text.Encoding.UTF8.GetBytes(ownerPassword));
//            encryptionProperties.AddPermissions(permissions);

//            // Aplicar a proteção por senha ao PDF
//            var pdfDocument = new PdfDocument(pdfReader, pdfWriter);
//            pdfDocument.SetEncryption(encryptionProperties);
//        }
//    }
//}






//retorna em bytes

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Caminho para o arquivo PDF existente
//        string pdfFilePath = "existing_file.pdf";

//        // Senha para o usuário e senha do proprietário
//        string userPassword = "userPassword";
//        string ownerPassword = "ownerPassword";

//        // Permissões do PDF (somente leitura)
//        var permissions = EncryptionConstants.ALLOW_PRINTING;

//        // Aplicar proteção por senha com permissões restritas ao PDF existente
//        byte[] protectedPdfBytes = ApplyPdfPasswordProtection(pdfFilePath, userPassword, ownerPassword, permissions);

//        // Escrever os bytes do arquivo PDF protegido em um novo arquivo
//        File.WriteAllBytes("output_protected.pdf", protectedPdfBytes);

//        Console.WriteLine("PDF protegido como somente leitura com sucesso!");
//    }

//    static byte[] ApplyPdfPasswordProtection(string inputPdfPath, string userPassword, string ownerPassword, int permissions)
//    {
//        using (MemoryStream outputStream = new MemoryStream())
//        {
//            // Abrir o PDF existente
//            using (var pdfReader = new PdfReader(inputPdfPath))
//            using (var pdfWriter = new PdfWriter(outputStream))
//            {
//                // Configurar a proteção por senha
//                var encryptionProperties = new PdfEncryption();
//                encryptionProperties.SetUserPassword(System.Text.Encoding.UTF8.GetBytes(userPassword));
//                encryptionProperties.SetOwnerPassword(System.Text.Encoding.UTF8.GetBytes(ownerPassword));
//                encryptionProperties.AddPermissions(permissions);

//                // Aplicar a proteção por senha ao PDF
//                var pdfDocument = new PdfDocument(pdfReader, pdfWriter);
//                pdfDocument.SetEncryption(encryptionProperties);
//            }

//            // Obter os bytes do MemoryStream
//            return outputStream.ToArray();
//        }
//    }
//}


//passando como array de bytes
//using System;
//using System.IO;
//using iText.Kernel.Pdf;
//using iText.Kernel.Pdf.Encryption;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Ler o arquivo PDF existente e convertê-lo para um array de bytes
//        string pdfFilePath = "existing_file.pdf";
//        byte[] pdfBytes = File.ReadAllBytes(pdfFilePath);

//        // Senha para o usuário e senha do proprietário
//        string userPassword = "userPassword";
//        string ownerPassword = "ownerPassword";

//        // Permissões do PDF (somente leitura)
//        var permissions = EncryptionConstants.ALLOW_PRINTING;

//        // Aplicar proteção por senha com permissões restritas ao PDF existente
//        byte[] protectedPdfBytes = ApplyPdfPasswordProtection(pdfBytes, userPassword, ownerPassword, permissions);

//        // Escrever os bytes do arquivo PDF protegido em um novo arquivo
//        File.WriteAllBytes("output_protected.pdf", protectedPdfBytes);

//        Console.WriteLine("PDF protegido como somente leitura com sucesso!");
//    }

//    static byte[] ApplyPdfPasswordProtection(byte[] pdfBytes, string userPassword, string ownerPassword, int permissions)
//    {
//        using (MemoryStream inputStream = new MemoryStream(pdfBytes))
//        using (MemoryStream outputStream = new MemoryStream())
//        {
//            // Abrir o PDF existente a partir do array de bytes
//            using (var pdfReader = new PdfReader(inputStream))
//            using (var pdfWriter = new PdfWriter(outputStream))
//            {
//                // Configurar a proteção por senha
//                var encryptionProperties = new PdfEncryption();
//                encryptionProperties.SetUserPassword(System.Text.Encoding.UTF8.GetBytes(userPassword));
//                encryptionProperties.SetOwnerPassword(System.Text.Encoding.UTF8.GetBytes(ownerPassword));
//                encryptionProperties.AddPermissions(permissions);

//                // Aplicar a proteção por senha ao PDF
//                var pdfDocument = new PdfDocument(pdfReader, pdfWriter);
//                pdfDocument.SetEncryption(encryptionProperties);
//            }

//            // Obter os bytes do MemoryStream de saída
//            return outputStream.ToArray();
//        }
//    }
//}