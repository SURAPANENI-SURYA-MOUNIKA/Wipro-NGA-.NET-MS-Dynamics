using Xunit;
using SolidPrinciples.ReportingSystemDemo.Services;

using SolidPrinciples.ReportingSystemDemo.Interfaces;
namespace xunitTestSolidPrinciples
{
    public class ReportServiceTests
    {



        [Fact]
        public void ProcessReport_ShouldExecuteWithoutError()
        {
            IReportGenerator generator = new ReportGenerator();
            IReportFormatter formatter = new PdfReportFormatter();
            IReportSaver saver = new FileReportSaver();

            var service = new ReportService(generator, formatter, saver);

            service.ProcessReport();

            Assert.True(true);
        }
    }
}
