using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsConnectBotAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsConnectBotAssociation.DataAwsConnectBotAssociationLexBot")]
    public class DataAwsConnectBotAssociationLexBot : aws.DataAwsConnectBotAssociation.IDataAwsConnectBotAssociationLexBot
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_bot_association#name DataAwsConnectBotAssociation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_bot_association#lex_region DataAwsConnectBotAssociation#lex_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lexRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LexRegion
        {
            get;
            set;
        }
    }
}
