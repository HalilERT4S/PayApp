using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PayApp
{
    public class ClassGenerator
    {
        public void GenerateClasses(List<PaymentMethod> paymentMethods)
        {

            string outputDirectory = Path.Combine("C:\\Users\\halil\\OneDrive\\Masaüstü\\dogus-bootcamp\\BirinciProje\\PayApp\\PayApp", "PaymentMethods");
            Console.WriteLine(outputDirectory);


            if (!Directory.Exists(outputDirectory))
            {
                try
                {
                    Directory.CreateDirectory(outputDirectory);
                    Console.WriteLine($"Dizin oluşturuldu: {outputDirectory}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: Dizin oluşturulamadı: {outputDirectory} - {ex.Message}");
                    return;
                }
            }

            Console.WriteLine($"Oluşturulacak ödeme metodu sayısı: {paymentMethods.Count}");

            foreach (PaymentMethod paymentMethod in paymentMethods)
            {
                var fileName = Path.Combine(outputDirectory, $"{paymentMethod.ClassName}.cs");

                try
                {
                    var classCode = GenerateClassCode(paymentMethod);
                    File.WriteAllText(fileName, classCode);
                    Console.WriteLine($"{fileName} dosyası oluşturuldu.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {fileName} dosyası oluşturulurken hata oluştu: {ex.Message}");
                }
            }
        }

        private string GenerateClassCode(PaymentMethod paymentMethod)
        {
            var sb = new StringBuilder();

            sb.AppendLine("using System;");
            sb.AppendLine("using PayApp;");
            sb.AppendLine();

            sb.AppendLine("namespace PayApp.PaymentMethods");
            sb.AppendLine("{");
            sb.AppendLine($"    public class {paymentMethod.ClassName} : IPaymentMethod");
            sb.AppendLine("    {");
            sb.AppendLine($"        public string GetPaymentDetails(decimal amount)");
            sb.AppendLine("        {");
            sb.AppendLine($"            return $\"{paymentMethod.DisplayName} ile {{amount}} TL Ödeme Yapıldı. \";");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}
