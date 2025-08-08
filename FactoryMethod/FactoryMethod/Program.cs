using FactoryMethod.Factories;
using FactoryMethod.Interface;

RelatorioFactory pdfFactory = new PdfRelatorioFactory();
RelatorioFactory csvFactory = new CsvRelatorioFactory();
RelatorioFactory excelFactory = new ExcelRelatorioFactory();

IRelatorio pdfRelatorio = pdfFactory.CriarRelatorio();
IRelatorio csvRelatorio = csvFactory.CriarRelatorio();
IRelatorio excelRelatorio = excelFactory.CriarRelatorio();

pdfRelatorio.Exportar();
csvRelatorio.Exportar();
excelRelatorio.Exportar();