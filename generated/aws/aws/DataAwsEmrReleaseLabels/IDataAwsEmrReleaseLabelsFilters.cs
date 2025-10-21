using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEmrReleaseLabels
{
    [JsiiInterface(nativeType: typeof(IDataAwsEmrReleaseLabelsFilters), fullyQualifiedName: "aws.dataAwsEmrReleaseLabels.DataAwsEmrReleaseLabelsFilters")]
    public interface IDataAwsEmrReleaseLabelsFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_release_labels#application DataAwsEmrReleaseLabels#application}.</summary>
        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Application
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_release_labels#prefix DataAwsEmrReleaseLabels#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEmrReleaseLabelsFilters), fullyQualifiedName: "aws.dataAwsEmrReleaseLabels.DataAwsEmrReleaseLabelsFilters")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEmrReleaseLabels.IDataAwsEmrReleaseLabelsFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_release_labels#application DataAwsEmrReleaseLabels#application}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Application
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_release_labels#prefix DataAwsEmrReleaseLabels#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
