using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceNetworkConfigurationIngressConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceNetworkConfigurationIngressConfiguration")]
    public interface IApprunnerServiceNetworkConfigurationIngressConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#is_publicly_accessible ApprunnerService#is_publicly_accessible}.</summary>
        [JsiiProperty(name: "isPubliclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPubliclyAccessible
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceNetworkConfigurationIngressConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceNetworkConfigurationIngressConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ApprunnerService.IApprunnerServiceNetworkConfigurationIngressConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#is_publicly_accessible ApprunnerService#is_publicly_accessible}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isPubliclyAccessible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsPubliclyAccessible
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
