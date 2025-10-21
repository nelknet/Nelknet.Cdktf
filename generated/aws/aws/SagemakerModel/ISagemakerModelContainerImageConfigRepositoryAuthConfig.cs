using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelContainerImageConfigRepositoryAuthConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerImageConfigRepositoryAuthConfig")]
    public interface ISagemakerModelContainerImageConfigRepositoryAuthConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#repository_credentials_provider_arn SagemakerModel#repository_credentials_provider_arn}.</summary>
        [JsiiProperty(name: "repositoryCredentialsProviderArn", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryCredentialsProviderArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelContainerImageConfigRepositoryAuthConfig), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerImageConfigRepositoryAuthConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerModel.ISagemakerModelContainerImageConfigRepositoryAuthConfig
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
