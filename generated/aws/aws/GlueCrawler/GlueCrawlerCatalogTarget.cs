using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCrawler
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueCrawler.GlueCrawlerCatalogTarget")]
    public class GlueCrawlerCatalogTarget : aws.GlueCrawler.IGlueCrawlerCatalogTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#database_name GlueCrawler#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#tables GlueCrawler#tables}.</summary>
        [JsiiProperty(name: "tables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Tables
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#connection_name GlueCrawler#connection_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#dlq_event_queue_arn GlueCrawler#dlq_event_queue_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dlqEventQueueArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DlqEventQueueArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#event_queue_arn GlueCrawler#event_queue_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventQueueArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventQueueArn
        {
            get;
            set;
        }
    }
}
