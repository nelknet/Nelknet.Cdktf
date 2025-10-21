using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RedshiftdataStatement
{
    [JsiiInterface(nativeType: typeof(IRedshiftdataStatementTimeouts), fullyQualifiedName: "aws.redshiftdataStatement.RedshiftdataStatementTimeouts")]
    public interface IRedshiftdataStatementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#create RedshiftdataStatement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftdataStatementTimeouts), fullyQualifiedName: "aws.redshiftdataStatement.RedshiftdataStatementTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.RedshiftdataStatement.IRedshiftdataStatementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftdata_statement#create RedshiftdataStatement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
