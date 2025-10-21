using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEmrReleaseLabels
{
    [JsiiByValue(fqn: "aws.dataAwsEmrReleaseLabels.DataAwsEmrReleaseLabelsFilters")]
    public class DataAwsEmrReleaseLabelsFilters : aws.DataAwsEmrReleaseLabels.IDataAwsEmrReleaseLabelsFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_release_labels#application DataAwsEmrReleaseLabels#application}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Application
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_release_labels#prefix DataAwsEmrReleaseLabels#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
