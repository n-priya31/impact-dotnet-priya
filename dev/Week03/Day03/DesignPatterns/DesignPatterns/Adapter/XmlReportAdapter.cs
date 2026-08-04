using System;

public class XmlReportAdapter
{
    private readonly JsonReport _jsonReport;
    private readonly ThirdPartyXmlGenerator _xmlGenerator;

    public XmlReportAdapter()
    {
        _jsonReport = new JsonReport();
        _xmlGenerator = new ThirdPartyXmlGenerator();
    }

    public void GenerateReport()
    {
        string json = _jsonReport.GetJsonData();

        // Simulated JSON → XML conversion
        string xml =
            "<Report>" +
            "<Customer>Priya</Customer>" +
            "<Amount>5000</Amount>" +
            "</Report>";

        _xmlGenerator.GenerateXml(xml);
    }
}