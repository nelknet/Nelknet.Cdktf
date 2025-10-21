using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoResourceServer
{
    [JsiiInterface(nativeType: typeof(ICognitoResourceServerScope), fullyQualifiedName: "aws.cognitoResourceServer.CognitoResourceServerScope")]
    public interface ICognitoResourceServerScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#scope_description CognitoResourceServer#scope_description}.</summary>
        [JsiiProperty(name: "scopeDescription", typeJson: "{\"primitive\":\"string\"}")]
        string ScopeDescription
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#scope_name CognitoResourceServer#scope_name}.</summary>
        [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}")]
        string ScopeName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoResourceServerScope), fullyQualifiedName: "aws.cognitoResourceServer.CognitoResourceServerScope")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoResourceServer.ICognitoResourceServerScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#scope_description CognitoResourceServer#scope_description}.</summary>
            [JsiiProperty(name: "scopeDescription", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopeDescription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_resource_server#scope_name CognitoResourceServer#scope_name}.</summary>
            [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopeName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
