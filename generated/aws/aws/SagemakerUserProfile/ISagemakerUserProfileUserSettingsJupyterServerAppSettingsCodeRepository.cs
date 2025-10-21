using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository")]
    public interface ISagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#repository_url SagemakerUserProfile#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsCodeRepository
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#repository_url SagemakerUserProfile#repository_url}.</summary>
            [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
