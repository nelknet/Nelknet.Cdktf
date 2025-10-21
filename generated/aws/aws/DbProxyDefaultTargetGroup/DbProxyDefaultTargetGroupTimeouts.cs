using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbProxyDefaultTargetGroup
{
    [JsiiByValue(fqn: "aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupTimeouts")]
    public class DbProxyDefaultTargetGroupTimeouts : aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#create DbProxyDefaultTargetGroup#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#update DbProxyDefaultTargetGroup#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
