using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecoveryreadinessRecoveryGroup
{
    [JsiiInterface(nativeType: typeof(IRoute53RecoveryreadinessRecoveryGroupTimeouts), fullyQualifiedName: "aws.route53RecoveryreadinessRecoveryGroup.Route53RecoveryreadinessRecoveryGroupTimeouts")]
    public interface IRoute53RecoveryreadinessRecoveryGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_recovery_group#delete Route53RecoveryreadinessRecoveryGroup#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecoveryreadinessRecoveryGroupTimeouts), fullyQualifiedName: "aws.route53RecoveryreadinessRecoveryGroup.Route53RecoveryreadinessRecoveryGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Route53RecoveryreadinessRecoveryGroup.IRoute53RecoveryreadinessRecoveryGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_recovery_group#delete Route53RecoveryreadinessRecoveryGroup#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
