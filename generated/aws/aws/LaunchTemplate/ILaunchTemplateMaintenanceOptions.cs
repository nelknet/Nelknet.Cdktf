using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateMaintenanceOptions), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateMaintenanceOptions")]
    public interface ILaunchTemplateMaintenanceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#auto_recovery LaunchTemplate#auto_recovery}.</summary>
        [JsiiProperty(name: "autoRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoRecovery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateMaintenanceOptions), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateMaintenanceOptions")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchTemplate.ILaunchTemplateMaintenanceOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#auto_recovery LaunchTemplate#auto_recovery}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoRecovery
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
