using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueTrigger
{
    [JsiiByValue(fqn: "aws.glueTrigger.GlueTriggerPredicateConditions")]
    public class GlueTriggerPredicateConditions : aws.GlueTrigger.IGlueTriggerPredicateConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#crawler_name GlueTrigger#crawler_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crawlerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrawlerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#crawl_state GlueTrigger#crawl_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crawlState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrawlState
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#job_name GlueTrigger#job_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JobName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#logical_operator GlueTrigger#logical_operator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logicalOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogicalOperator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#state GlueTrigger#state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }
    }
}
