using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecoveryreadinessResourceSet
{
    [JsiiInterface(nativeType: typeof(IRoute53RecoveryreadinessResourceSetTimeouts), fullyQualifiedName: "aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetTimeouts")]
    public interface IRoute53RecoveryreadinessResourceSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#delete Route53RecoveryreadinessResourceSet#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecoveryreadinessResourceSetTimeouts), fullyQualifiedName: "aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#delete Route53RecoveryreadinessResourceSet#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
