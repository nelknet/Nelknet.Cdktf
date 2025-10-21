using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsServicecatalogConstraint
{
    [JsiiInterface(nativeType: typeof(IDataAwsServicecatalogConstraintTimeouts), fullyQualifiedName: "aws.dataAwsServicecatalogConstraint.DataAwsServicecatalogConstraintTimeouts")]
    public interface IDataAwsServicecatalogConstraintTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_constraint#read DataAwsServicecatalogConstraint#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsServicecatalogConstraintTimeouts), fullyQualifiedName: "aws.dataAwsServicecatalogConstraint.DataAwsServicecatalogConstraintTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsServicecatalogConstraint.IDataAwsServicecatalogConstraintTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_constraint#read DataAwsServicecatalogConstraint#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
