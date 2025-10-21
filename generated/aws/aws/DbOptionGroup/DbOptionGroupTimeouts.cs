using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbOptionGroup
{
    [JsiiByValue(fqn: "aws.dbOptionGroup.DbOptionGroupTimeouts")]
    public class DbOptionGroupTimeouts : aws.DbOptionGroup.IDbOptionGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#delete DbOptionGroup#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
