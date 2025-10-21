using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceEncryptionConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceEncryptionConfiguration")]
    public interface IApprunnerServiceEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#kms_key ApprunnerService#kms_key}.</summary>
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}")]
        string KmsKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceEncryptionConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ApprunnerService.IApprunnerServiceEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#kms_key ApprunnerService#kms_key}.</summary>
            [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
