using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateHibernationOptions), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateHibernationOptions")]
    public interface ILaunchTemplateHibernationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#configured LaunchTemplate#configured}.</summary>
        [JsiiProperty(name: "configured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Configured
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateHibernationOptions), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateHibernationOptions")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchTemplate.ILaunchTemplateHibernationOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#configured LaunchTemplate#configured}.</summary>
            [JsiiProperty(name: "configured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Configured
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
