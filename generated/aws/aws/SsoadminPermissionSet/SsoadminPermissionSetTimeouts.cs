using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminPermissionSet
{
    [JsiiByValue(fqn: "aws.ssoadminPermissionSet.SsoadminPermissionSetTimeouts")]
    public class SsoadminPermissionSetTimeouts : aws.SsoadminPermissionSet.ISsoadminPermissionSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#update SsoadminPermissionSet#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
