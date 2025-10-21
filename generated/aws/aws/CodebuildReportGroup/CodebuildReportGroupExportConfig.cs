using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildReportGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuildReportGroup.CodebuildReportGroupExportConfig")]
    public class CodebuildReportGroupExportConfig : aws.CodebuildReportGroup.ICodebuildReportGroupExportConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#type CodebuildReportGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>s3_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#s3_destination CodebuildReportGroup#s3_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.codebuildReportGroup.CodebuildReportGroupExportConfigS3Destination\"}", isOptional: true)]
        public aws.CodebuildReportGroup.ICodebuildReportGroupExportConfigS3Destination? S3Destination
        {
            get;
            set;
        }
    }
}
