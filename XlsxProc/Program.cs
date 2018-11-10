using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ClosedXML.Excel;

namespace XlsxProc {
    class Program {
        static void Main(string[] args) {

            if (args == null || args.Length != 2) {
                Console.WriteLine("Error: You must drag exactly two files on to XlsxProc.exe.");
                Console.WriteLine();
                Console.WriteLine("Incorrect operation of this program will be punished with a dad joke.");
                Console.WriteLine("Please ready the errant human brain:");
                Console.WriteLine();
                Console.WriteLine(DadJoke.Get());
                Console.WriteLine();
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                return;
            }

            if (!Run(args)) {
                Console.WriteLine();
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }

        public static bool Run(string[] args) {
            XLWorkbook getWorkbook(string path) {
                try {
                    return new XLWorkbook(path);
                }
                catch (Exception ex) {
                    Console.WriteLine($"Error: Could not open file: {path}");
                    Console.WriteLine();
                    Console.WriteLine($"Error Message: {ex.Message}");
                    return null;
                }
            }

            IXLWorksheet getWorkSheet(string path, XLWorkbook wb) {
                try {
                    return wb.Worksheets.First();
                }
                catch (Exception ex) {
                    Console.WriteLine($"Error: Could not open first Worksheet in {path}.");
                    Console.WriteLine();
                    Console.WriteLine($"Error Message: {ex.Message}");
                    return null;
                }
            }

            string getOutputPath() {
                var i = 1;
                var outputPath = $"./{i}.xlsx";
                while (File.Exists(outputPath)) {
                    i++;
                    outputPath = $"./{i}.xlsx";
                }
                return outputPath;
            }

            void JoinOnFirstColumn(string outSheetName, XLWorkbook addSheetTo, IXLWorksheet s1, IXLWorksheet s2, bool skipMatch) {
                var w = addSheetTo;
                var matchCount = 0;
                var outSheetMatch = skipMatch? null : w.AddWorksheet("Matches");
                var missingCount = 0;
                var outSheetMissing = w.AddWorksheet($"Missing from {outSheetName}");
                var s2Rows = s2.Rows();
                var low = 250;
                var high = 255;
                var c1 = XLColor.FromArgb(128, low, low, high);
                var c2 = XLColor.FromArgb(128, low, high, low);

                foreach (var row in s1.Rows()) {
                    var id = ((string)row.FirstCell().GetString()).Trim();
                    var matchingRow = s2Rows.FirstOrDefault(x => string.Compare(x.FirstCell().GetString().Trim(), id, true) == 0);
                    if (matchingRow == null) {
                        missingCount++;
                        var col = 0;
                        foreach (var cell in row.Cells()) {
                            col++;
                            outSheetMissing.Cell(missingCount, cell.WorksheetColumn().ColumnNumber()).Value = cell.Value;
                        }
                    }
                    else if(!skipMatch){
                        matchCount++;
                        var col = 0;
                        var maxColNumber = 1;
                        foreach (var cell in row.Cells()) {
                            col++;
                            var colNumber = cell.WorksheetColumn().ColumnNumber();
                            maxColNumber = Math.Max(maxColNumber, colNumber);
                            var outCell = outSheetMatch.Cell(matchCount, colNumber);
                            outCell.Value = cell.Value;
                            outCell.Style.Fill.SetBackgroundColor(c1);
                            outCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            //outCell.Style.Border.SetOutsideBorderColor(XLColor.Black);
                        }
                        var colOffset = maxColNumber;
                        foreach (var cell in matchingRow.Cells()) {
                            col++;
                            var outCell = outSheetMatch.Cell(matchCount, cell.WorksheetColumn().ColumnNumber() + colOffset);
                            outCell.Value = cell.Value;
                            outCell.Style.Fill.SetBackgroundColor(c2);
                            outCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            //outCell.Style.Border.SetOutsideBorderColor(XLColor.Black);
                        }
                    }
                }

                if (!skipMatch) {
                    foreach (var col in outSheetMatch.Columns()) {
                        col.AdjustToContents();
                    }
                }
                foreach (var col in outSheetMissing.Columns()) {
                    col.AdjustToContents();
                }
            }

            using (var wb1 = getWorkbook(args[0]))
            using (var wb2 = getWorkbook(args[1])) {
                if (wb1 == null || wb2 == null) {
                    return false;
                }
                using (var sheet1 = getWorkSheet(args[0], wb1))
                using (var sheet2 = getWorkSheet(args[1], wb2)) {
                    if (sheet1 == null || sheet2 == null) {
                        return false;
                    }
                    using (var outBook = new XLWorkbook()) {
                        var outPath = getOutputPath();
                        JoinOnFirstColumn("A", outBook, sheet1, sheet2, skipMatch:false);
                        JoinOnFirstColumn("B", outBook, sheet2, sheet1, skipMatch:true);
                        outBook.SaveAs(outPath, new SaveOptions() {
                        });
                    }
                }
            }
            return true;
        }
    }
}
