using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecoveryreadinessCell
{
    [JsiiInterface(nativeType: typeof(IRoute53RecoveryreadinessCellTimeouts), fullyQualifiedName: "aws.route53RecoveryreadinessCell.Route53RecoveryreadinessCellTimeouts")]
    public interface IRoute53RecoveryreadinessCellTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_cell#delete Route53RecoveryreadinessCell#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecoveryreadinessCellTimeouts), fullyQualifiedName: "aws.route53RecoveryreadinessCell.Route53RecoveryreadinessCellTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Route53RecoveryreadinessCell.IRoute53RecoveryreadinessCellTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_cell#delete Route53RecoveryreadinessCell#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
