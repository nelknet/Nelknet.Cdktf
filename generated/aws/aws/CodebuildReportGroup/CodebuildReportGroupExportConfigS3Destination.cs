using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildReportGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuildReportGroup.CodebuildReportGroupExportConfigS3Destination")]
    public class CodebuildReportGroupExportConfigS3Destination : aws.CodebuildReportGroup.ICodebuildReportGroupExportConfigS3Destination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#bucket CodebuildReportGroup#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#encryption_key CodebuildReportGroup#encryption_key}.</summary>
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}")]
        public string EncryptionKey
        {
            get;
            set;
        }

        private object? _encryptionDisabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#encryption_disabled CodebuildReportGroup#encryption_disabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EncryptionDisabled
        {
            get => _encryptionDisabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _encryptionDisabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#packaging CodebuildReportGroup#packaging}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "packaging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Packaging
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_report_group#path CodebuildReportGroup#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
