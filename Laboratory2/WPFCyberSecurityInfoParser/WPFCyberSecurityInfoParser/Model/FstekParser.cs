using System.Collections.ObjectModel;
using ClosedXML.Excel;
using WPFCyberSecurityInfoParser.Model.Types;

namespace WPFCyberSecurityInfoParser.Model
{
    public static class FstekParser
    {
        public static ObservableCollection<ThreatData> Parse(string pathToXlsx)
        {
            var observableCollection = new ObservableCollection<ThreatData>();

            using (var workbook = new XLWorkbook(pathToXlsx))
            {
                var worksheet = workbook.Worksheet(1);
                var firstRowUsed = worksheet.FirstRowUsed();
                var idRow = firstRowUsed.RowUsed();

                idRow = idRow.RowBelow(2);

                while (!idRow.Cell(1).IsEmpty())
                {
                    var threatData = new ThreatData
                    {
                        Id = idRow.Cell(1).GetString(),
                        Name = idRow.Cell(2).GetString(),
                        Description = idRow.Cell(3).GetString(),
                        ThreatSource = idRow.Cell(4).GetString(),
                        ImpactObject = idRow.Cell(5).GetString(),
                        IsPrivacyViolation = idRow.Cell(6).GetString(),
                        IsIntegrityViolation = idRow.Cell(7).GetString(),
                        IsAvailabilityViolation = idRow.Cell(8).GetString()
                    };

                    observableCollection.Add(threatData);
                    idRow = idRow.RowBelow();
                }
            }

            return observableCollection;
        }
    }
}
