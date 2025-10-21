using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCrawler
{
    [JsiiByValue(fqn: "aws.glueCrawler.GlueCrawlerSchemaChangePolicy")]
    public class GlueCrawlerSchemaChangePolicy : aws.GlueCrawler.IGlueCrawlerSchemaChangePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#delete_behavior GlueCrawler#delete_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeleteBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#update_behavior GlueCrawler#update_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdateBehavior
        {
            get;
            set;
        }
    }
}
