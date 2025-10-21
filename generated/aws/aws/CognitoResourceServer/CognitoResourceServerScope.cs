using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoResourceServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoResourceServer.CognitoResourceServerScope")]
    public class CognitoResourceServerScope : aws.CognitoResourceServer.ICognitoResourceServerScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#scope_description CognitoResourceServer#scope_description}.</summary>
        [JsiiProperty(name: "scopeDescription", typeJson: "{\"primitive\":\"string\"}")]
        public string ScopeDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#scope_name CognitoResourceServer#scope_name}.</summary>
        [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}")]
        public string ScopeName
        {
            get;
            set;
        }
    }
}
