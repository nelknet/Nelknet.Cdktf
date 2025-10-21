using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2DelegatedAdminAccount
{
    [JsiiByValue(fqn: "aws.inspector2DelegatedAdminAccount.Inspector2DelegatedAdminAccountTimeouts")]
    public class Inspector2DelegatedAdminAccountTimeouts : aws.Inspector2DelegatedAdminAccount.IInspector2DelegatedAdminAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_delegated_admin_account#create Inspector2DelegatedAdminAccount#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_delegated_admin_account#delete Inspector2DelegatedAdminAccount#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
