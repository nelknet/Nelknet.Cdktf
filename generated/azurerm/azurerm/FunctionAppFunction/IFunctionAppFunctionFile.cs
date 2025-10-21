using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppFunction
{
    [JsiiInterface(nativeType: typeof(IFunctionAppFunctionFile), fullyQualifiedName: "azurerm.functionAppFunction.FunctionAppFunctionFile")]
    public interface IFunctionAppFunctionFile
    {
        /// <summary>The content of the file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#content FunctionAppFunction#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>The filename of the file to be uploaded.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#name FunctionAppFunction#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppFunctionFile), fullyQualifiedName: "azurerm.functionAppFunction.FunctionAppFunctionFile")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppFunction.IFunctionAppFunctionFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The content of the file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#content FunctionAppFunction#content}
            /// </remarks>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The filename of the file to be uploaded.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_function#name FunctionAppFunction#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
