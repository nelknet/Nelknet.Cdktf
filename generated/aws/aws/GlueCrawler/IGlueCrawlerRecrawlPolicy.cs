using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCrawler
{
    [JsiiInterface(nativeType: typeof(IGlueCrawlerRecrawlPolicy), fullyQualifiedName: "aws.glueCrawler.GlueCrawlerRecrawlPolicy")]
    public interface IGlueCrawlerRecrawlPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#recrawl_behavior GlueCrawler#recrawl_behavior}.</summary>
        [JsiiProperty(name: "recrawlBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecrawlBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCrawlerRecrawlPolicy), fullyQualifiedName: "aws.glueCrawler.GlueCrawlerRecrawlPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCrawler.IGlueCrawlerRecrawlPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#recrawl_behavior GlueCrawler#recrawl_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recrawlBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecrawlBehavior
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
