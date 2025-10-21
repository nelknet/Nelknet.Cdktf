using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftdataStatement
{
    [JsiiByValue(fqn: "aws.redshiftdataStatement.RedshiftdataStatementTimeouts")]
    public class RedshiftdataStatementTimeouts : aws.RedshiftdataStatement.IRedshiftdataStatementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#create RedshiftdataStatement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
