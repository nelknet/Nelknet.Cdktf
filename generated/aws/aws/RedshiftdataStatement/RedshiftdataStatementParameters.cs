using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftdataStatement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.redshiftdataStatement.RedshiftdataStatementParameters")]
    public class RedshiftdataStatementParameters : aws.RedshiftdataStatement.IRedshiftdataStatementParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#name RedshiftdataStatement#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#value RedshiftdataStatement#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
