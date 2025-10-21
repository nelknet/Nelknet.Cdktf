using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainRetentionPolicy), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainRetentionPolicy")]
    public interface ISagemakerDomainRetentionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#home_efs_file_system SagemakerDomain#home_efs_file_system}.</summary>
        [JsiiProperty(name: "homeEfsFileSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HomeEfsFileSystem
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainRetentionPolicy), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainRetentionPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainRetentionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#home_efs_file_system SagemakerDomain#home_efs_file_system}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "homeEfsFileSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HomeEfsFileSystem
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
