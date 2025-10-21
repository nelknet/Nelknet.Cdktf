using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainRetentionPolicy")]
    public class SagemakerDomainRetentionPolicy : aws.SagemakerDomain.ISagemakerDomainRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#home_efs_file_system SagemakerDomain#home_efs_file_system}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "homeEfsFileSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HomeEfsFileSystem
        {
            get;
            set;
        }
    }
}
