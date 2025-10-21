using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsConnectBotAssociation
{
    [JsiiInterface(nativeType: typeof(IDataAwsConnectBotAssociationLexBot), fullyQualifiedName: "aws.dataAwsConnectBotAssociation.DataAwsConnectBotAssociationLexBot")]
    public interface IDataAwsConnectBotAssociationLexBot
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_bot_association#name DataAwsConnectBotAssociation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_bot_association#lex_region DataAwsConnectBotAssociation#lex_region}.</summary>
        [JsiiProperty(name: "lexRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LexRegion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsConnectBotAssociationLexBot), fullyQualifiedName: "aws.dataAwsConnectBotAssociation.DataAwsConnectBotAssociationLexBot")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsConnectBotAssociation.IDataAwsConnectBotAssociationLexBot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_bot_association#name DataAwsConnectBotAssociation#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_bot_association#lex_region DataAwsConnectBotAssociation#lex_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lexRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LexRegion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
