using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiInterface(nativeType: typeof(ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository")]
    public interface ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#repository_url SagemakerSpace#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#repository_url SagemakerSpace#repository_url}.</summary>
            [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
