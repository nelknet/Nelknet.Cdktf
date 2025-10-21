using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2DelegatedAdminAccount
{
    [JsiiInterface(nativeType: typeof(IInspector2DelegatedAdminAccountTimeouts), fullyQualifiedName: "aws.inspector2DelegatedAdminAccount.Inspector2DelegatedAdminAccountTimeouts")]
    public interface IInspector2DelegatedAdminAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_delegated_admin_account#create Inspector2DelegatedAdminAccount#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_delegated_admin_account#delete Inspector2DelegatedAdminAccount#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInspector2DelegatedAdminAccountTimeouts), fullyQualifiedName: "aws.inspector2DelegatedAdminAccount.Inspector2DelegatedAdminAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Inspector2DelegatedAdminAccount.IInspector2DelegatedAdminAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_delegated_admin_account#create Inspector2DelegatedAdminAccount#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_delegated_admin_account#delete Inspector2DelegatedAdminAccount#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
