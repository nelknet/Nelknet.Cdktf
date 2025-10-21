using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig")]
    public interface ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#repository_credentials_provider_arn SagemakerModel#repository_credentials_provider_arn}.</summary>
        [JsiiProperty(name: "repositoryCredentialsProviderArn", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryCredentialsProviderArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfigRepositoryAuthConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#repository_credentials_provider_arn SagemakerModel#repository_credentials_provider_arn}.</summary>
            [JsiiProperty(name: "repositoryCredentialsProviderArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryCredentialsProviderArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
