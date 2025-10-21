using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCrawler
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueCrawler.GlueCrawlerS3Target")]
    public class GlueCrawlerS3Target : aws.GlueCrawler.IGlueCrawlerS3Target
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#path GlueCrawler#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#exclusions GlueCrawler#exclusions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exclusions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Exclusions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#sample_size GlueCrawler#sample_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sampleSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SampleSize
        {
            get;
            set;
        }
    }
}
