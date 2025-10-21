using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateElasticInferenceAccelerator), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateElasticInferenceAccelerator")]
    public interface ILaunchTemplateElasticInferenceAccelerator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#type LaunchTemplate#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateElasticInferenceAccelerator), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateElasticInferenceAccelerator")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchTemplate.ILaunchTemplateElasticInferenceAccelerator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#type LaunchTemplate#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
