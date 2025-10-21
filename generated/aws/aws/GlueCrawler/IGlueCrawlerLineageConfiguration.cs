using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCrawler
{
    [JsiiInterface(nativeType: typeof(IGlueCrawlerLineageConfiguration), fullyQualifiedName: "aws.glueCrawler.GlueCrawlerLineageConfiguration")]
    public interface IGlueCrawlerLineageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#crawler_lineage_settings GlueCrawler#crawler_lineage_settings}.</summary>
        [JsiiProperty(name: "crawlerLineageSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrawlerLineageSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCrawlerLineageConfiguration), fullyQualifiedName: "aws.glueCrawler.GlueCrawlerLineageConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCrawler.IGlueCrawlerLineageConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#crawler_lineage_settings GlueCrawler#crawler_lineage_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crawlerLineageSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrawlerLineageSettings
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
