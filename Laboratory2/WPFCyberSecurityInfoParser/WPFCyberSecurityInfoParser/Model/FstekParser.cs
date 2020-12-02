using System.Collections.ObjectModel;
using System.Windows;
using ClosedXML.Excel;
using WPFCyberSecurityInfoParser.Model.Types;

namespace WPFCyberSecurityInfoParser.Model
{
    public static class  FstekParser
    {
        public static ObservableCollection<ThreatData> ParseFullDatabase(string pathToXlsx)
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

        public static ObservableCollection<ShortThreatData> ParseShortDatabase(ObservableCollection<ThreatData> observableCollection)
        {
            var shortObservableCollection = new ObservableCollection<ShortThreatData>();

            foreach (var threatData in observableCollection)
            {
                shortObservableCollection.Add(new ShortThreatData
                {
                    Id = threatData.Id,
                    Name = threatData.Name
                });
            }

            return shortObservableCollection;
        }

        public static void GenerateComparedCollection(
            ObservableCollection<ThreatData> collectionBefore,
            ObservableCollection<ThreatData> collectionAfter,
            out ObservableCollection<ThreatData> comparedCollection)
        {
            comparedCollection = new ObservableCollection<ThreatData>();

            for (var i = 0; i < collectionBefore.Count; i++)
            {
                if (i == collectionAfter.Count) break;
                comparedCollection.Add(new ThreatData
                {
                    Id = collectionBefore[i].Id == collectionAfter[i].Id ? "-" : collectionAfter[i].Id,
                    Description = collectionBefore[i].Description == collectionAfter[i].Description
                        ? "-"
                        : collectionAfter[i].Description,
                    Name = collectionBefore[i].Name == collectionAfter[i].Name ? "-" : collectionAfter[i].Name,
                    ImpactObject = collectionBefore[i].ImpactObject == collectionAfter[i].ImpactObject
                        ? "-"
                        : collectionAfter[i].ImpactObject,
                    ThreatSource = collectionBefore[i].ThreatSource == collectionAfter[i].ThreatSource
                        ? "-"
                        : collectionAfter[i].ThreatSource,
                    IsAvailabilityViolation = collectionBefore[i].IsAvailabilityViolation ==
                                              collectionAfter[i].IsAvailabilityViolation
                        ? "-"
                        : collectionAfter[i].IsAvailabilityViolation,
                    IsIntegrityViolation = collectionBefore[i].IsIntegrityViolation ==
                                           collectionAfter[i].IsIntegrityViolation
                        ? "-"
                        : collectionAfter[i].IsIntegrityViolation,
                    IsPrivacyViolation = collectionBefore[i].IsPrivacyViolation == collectionAfter[i].IsPrivacyViolation
                        ? "-"
                        : collectionAfter[i].IsPrivacyViolation
                });
            }
        }
    }
}
