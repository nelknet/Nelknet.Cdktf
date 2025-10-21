using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrRepository
{
    [JsiiInterface(nativeType: typeof(IEcrRepositoryImageScanningConfiguration), fullyQualifiedName: "aws.ecrRepository.EcrRepositoryImageScanningConfiguration")]
    public interface IEcrRepositoryImageScanningConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#scan_on_push EcrRepository#scan_on_push}.</summary>
        [JsiiProperty(name: "scanOnPush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object ScanOnPush
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrRepositoryImageScanningConfiguration), fullyQualifiedName: "aws.ecrRepository.EcrRepositoryImageScanningConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EcrRepository.IEcrRepositoryImageScanningConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_repository#scan_on_push EcrRepository#scan_on_push}.</summary>
            [JsiiProperty(name: "scanOnPush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object ScanOnPush
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
