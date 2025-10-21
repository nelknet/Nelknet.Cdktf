using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCrawler
{
    [JsiiByValue(fqn: "aws.glueCrawler.GlueCrawlerLineageConfiguration")]
    public class GlueCrawlerLineageConfiguration : aws.GlueCrawler.IGlueCrawlerLineageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#crawler_lineage_settings GlueCrawler#crawler_lineage_settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crawlerLineageSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrawlerLineageSettings
        {
            get;
            set;
        }
    }
}
