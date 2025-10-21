using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelPrimaryContainerImageConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfig")]
    public interface ISagemakerModelPrimaryContainerImageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#repository_access_mode SagemakerModel#repository_access_mode}.</summary>
        [JsiiProperty(name: "repositoryAccessMode", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryAccessMode
        {
            get;
        }

        /// <summary>repository_auth_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#repository_auth_config SagemakerModel#repository_auth_config}
        /// </remarks>
        [JsiiProperty(name: "repositoryAuthConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelPrimaryContainerImageConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#repository_access_mode SagemakerModel#repository_access_mode}.</summary>
            [JsiiProperty(name: "repositoryAccessMode", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryAccessMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>repository_auth_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#repository_auth_config SagemakerModel#repository_auth_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryAuthConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig\"}", isOptional: true)]
            public aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig
            {
                get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig?>();
            }
        }
    }
}
