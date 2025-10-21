using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksAddon
{
    [JsiiInterface(nativeType: typeof(IEksAddonPodIdentityAssociation), fullyQualifiedName: "aws.eksAddon.EksAddonPodIdentityAssociation")]
    public interface IEksAddonPodIdentityAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#role_arn EksAddon#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#service_account EksAddon#service_account}.</summary>
        [JsiiProperty(name: "serviceAccount", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceAccount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksAddonPodIdentityAssociation), fullyQualifiedName: "aws.eksAddon.EksAddonPodIdentityAssociation")]
        internal sealed class _Proxy : DeputyBase, aws.EksAddon.IEksAddonPodIdentityAssociation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#role_arn EksAddon#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_addon#service_account EksAddon#service_account}.</summary>
            [JsiiProperty(name: "serviceAccount", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceAccount
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
