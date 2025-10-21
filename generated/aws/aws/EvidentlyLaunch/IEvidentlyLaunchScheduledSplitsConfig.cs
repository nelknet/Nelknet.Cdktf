using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    [JsiiInterface(nativeType: typeof(IEvidentlyLaunchScheduledSplitsConfig), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfig")]
    public interface IEvidentlyLaunchScheduledSplitsConfig
    {
        /// <summary>steps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#steps EvidentlyLaunch#steps}
        /// </remarks>
        [JsiiProperty(name: "steps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigSteps\"},\"kind\":\"array\"}}]}}")]
        object Steps
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEvidentlyLaunchScheduledSplitsConfig), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>steps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#steps EvidentlyLaunch#steps}
            /// </remarks>
            [JsiiProperty(name: "steps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigSteps\"},\"kind\":\"array\"}}]}}")]
            public object Steps
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
